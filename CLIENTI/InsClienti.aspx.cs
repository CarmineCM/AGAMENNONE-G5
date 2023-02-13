using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class InsClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClienti_Click(object sender, EventArgs e)
    {
       // controlli formali 
        
        if(txtRS.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // connessione al DB
        CLIENTI.RAGIONESOCIALE = txtRS.Text.Trim();
        CLIENTI.INDIRIZZO = txtIndirizzo.Text.Trim();
        CLIENTI.CITTA = txtCitta.Text.Trim();
        CLIENTI.CAP = txtCap.Text.Trim();
        CLIENTI.PROVINCIA = txtProvincia.Text.Trim();
        CLIENTI.EMAIL = txtEmail.Text.Trim();
        CLIENTI.TELEFONO = txtTelefono.Text.Trim();
        CLIENTI.CODICEFISCALE = txtCodiceFiscale.Text.Trim();
        CLIENTI.PIVA = txtIVA.Text.Trim();
        CLIENTI.PEC = txtPEC.Text.Trim();
        CLIENTI.CFE = txtCFE.Text.Trim();
        CLIENTI.TITOLARE = txtNomeTitolare.Text.Trim();
        CLIENTI.EMAILTITOLARE = txtEmailTitolare.Text.Trim();
        CLIENTI.TELTITOLARE = txtNumeroTitolare.Text.Trim();
        CLIENTI.spCLIENTI_Insert();
    }
}