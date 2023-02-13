using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //controlli formali
        if (txtEmail.Text.Trim() == "" || txtPWD.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }
        else
        {
            //controllo nel DB se esistono il nome utente e la password
            DIPENDENTI.EMAIL = txtEmail.Text.Trim();
            DIPENDENTI.PWD = CRYPTAZIONE.Crypta(txtPWD.Text.Trim());
            DataTable DT = new DataTable();
            DT = DIPENDENTI.spDIPENDENTI_Login();
            //se non esistono, return alla pagina login
            if (DT.Rows.Count == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Non ti conosco');", true);
                return;
            }
            else
            {
                //se l'utente non ha ancora cambiato la password dopo la prima registrazione, redirect sulla pagina per cambiare la password.
                if ((bool)DT.Rows[0]["PRIMOACCESSO"] == true)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Primo accesso rilevato. Cambiare la password tramite il pulsante Cambia Password in questa pagina prima di procedere.');", true);
                    return;
                }
                //se l'utente non è abilitato, return alla pagina login
                if ((bool)DT.Rows[0]["ABILITATO"] == false)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Utente non abilitato. Contattare l'amministratore.');", true);
                    return;
                }
                else
                {
                    //avvio la session
                    Session["EMAIL"] = DATABASE.DT.Rows[0]["EMAIL"];
                    Session["RUOLO"] = DATABASE.DT.Rows[0]["RUOLO"];
                    Session["chiaveDIPENDENTE"] = DATABASE.DT.Rows[0]["chiave"];
                    //inserisco l'accesso dell'utente nel log
                    ACCESSI.chiaveDIPENDENTE = DT.Rows[0]["chiave"].ToString();
                    ACCESSI.DATAORA = DateTime.Now.ToString();
                    ACCESSI.EVENTO = "L'utente " + txtEmail.Text.Trim() + " ha effettuato l'accesso.";
                    ACCESSI.spACCESSI_Insert();
                    DATABASE.DT.Clear();

                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}