using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CambioPasswordPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCambiaPWD_Click(object sender, EventArgs e)
    {
        //controlli formali
        //se almeno uno dei campi è vuoto, return
        if (txtEmail.Text.Trim() == "" || txtPWDOld.Text.Trim() == "" || txtPWDNew.Text.Trim() == "" || txtPWDControl.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }
        //se i due campi per la nuova password non sono uguali, return
        if (txtPWDNew.Text.Trim() != txtPWDControl.Text.Trim())
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('I campi per la nuova password non corrispondono. Assicurarsi che siano uguali.');", true);
            return;
        }
        //controllo nel DB se esistono il nome utente e la password
        DIPENDENTI.EMAIL = txtEmail.Text.Trim();
        DIPENDENTI.PWD = CRYPTAZIONE.Crypta(txtPWDOld.Text.Trim());
        DataTable DT = new DataTable();
        //sp per richiedere la chiave tramite email e password inseriti dall'utente
        DT = DIPENDENTI.spDIPENDENTI_GetchiaveByEMailPWD();
        if (DT.Rows.Count == 1)
        {
            //punto all'utente che voglio modificare tramite la chiave, imposto la nuova password, e sp per modificare il db
            DIPENDENTI.chiave = DT.Rows[0]["chiave"].ToString();
            DIPENDENTI.PWD = CRYPTAZIONE.Crypta(txtPWDNew.Text.Trim());
            DIPENDENTI.spDIPENDENTI_CambioPassword();
            DT.Clear();
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Password cambiata con successo!');", true);
            return;
        }
        else
        {
            //se nome utente e password non restiruiscono una row, return
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Combinazione utente e password non trovata. Assicurarsi che i dati siano corretti.');", true);
            return;
        }

    }
}