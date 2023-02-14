using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsReferente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // controlli formail 
        if (txtCognome.Text.Trim() == "" || txtNome.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // connessione al DB
        REFERENTI.chiaveCLIENTE = ddlClienti.SelectedValue;
        REFERENTI.COGNOME = txtCognome.Text.Trim();
        REFERENTI.NOME = txtNome.Text.Trim();
        REFERENTI.EMAIL = txtEmail.Text.Trim();
        REFERENTI.TELEFONO = txtTelefono.Text.Trim();
        REFERENTI.spREFERENTI_Insert();
    }
}