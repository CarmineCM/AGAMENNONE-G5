using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsAzienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnInserisciAzienda_Click(object sender, EventArgs e)
    {
        // controlli formali
        if(txtRagioneSociale.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // connessione al db
        AZIENDE.RAGIONESOCIALE = txtRagioneSociale.Text.Trim();
        AZIENDE.INDIRIZZO = txtIndirizzo.Text.Trim();
        AZIENDE.CITTA = txtCitta.Text.Trim();
        AZIENDE.CAP = txtCap.Text.Trim();
        AZIENDE.PROVINCIA = txtProvincia.Text.Trim();
        AZIENDE.EMAIL = txtEMail.Text.Trim();
        AZIENDE.TELEFONO = txtTelefono.Text.Trim();
        AZIENDE.CODICEFISCALE = txtCodiceFiscale.Text.Trim();
        AZIENDE.PIVA = txtPartivaIVA.Text.Trim();
        AZIENDE.PEC = txtPEC.Text.Trim();
        AZIENDE.CFE = txtCFE.Text.Trim();
        AZIENDE.TITOLARE = txtTitolare.Text.Trim();
        AZIENDE.EMAILTITOLARE = txtEMailTitolare.Text.Trim();
        AZIENDE.TELTITOLARE = txtTelTitolare.Text.Trim();
        AZIENDE.spAZIENDE_Insert();
    }
}