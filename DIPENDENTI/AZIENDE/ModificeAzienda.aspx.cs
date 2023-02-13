using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaAzienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Aziende"] == null)
        {
            return;
        }
        string chiavegrigliaClienti = Session["Aziende"].ToString();
        if (string.IsNullOrEmpty(chiavegrigliaClienti))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
            return;
        }
        if (!IsPostBack)
        {
            AZIENDE.chiave = chiavegrigliaClienti;
            AZIENDE.spAZIENDE_SelectByKey(); 

            txtRagioneSociale.Text = DATABASE.DT.Rows[0]["RAGIONESOCIALE"].ToString();
            txtIndirizzo.Text = DATABASE.DT.Rows[0]["INDIRIZZO"].ToString();
            txtCitta.Text = DATABASE.DT.Rows[0]["CITTA"].ToString();
            txtCap.Text = DATABASE.DT.Rows[0]["CAP"].ToString();
            txtProvincia.Text = DATABASE.DT.Rows[0]["PROVINCIA"].ToString();
            txtEMail.Text = DATABASE.DT.Rows[0]["EMAIL"].ToString();
            txtTelefono.Text = DATABASE.DT.Rows[0]["TELEFONO"].ToString();
            txtCodiceFiscale.Text = DATABASE.DT.Rows[0]["CODICEFISCALE"].ToString();
            txtPartivaIVA.Text = DATABASE.DT.Rows[0]["PIVA"].ToString();
            txtPEC.Text = DATABASE.DT.Rows[0]["PEC"].ToString();
            txtCFE.Text = DATABASE.DT.Rows[0]["CFE"].ToString();
            txtTitolare.Text = DATABASE.DT.Rows[0]["TITOLARE"].ToString();
            txtEMailTitolare.Text = DATABASE.DT.Rows[0]["EMAILTITOLARE"].ToString();
            txtTelTitolare.Text = DATABASE.DT.Rows[0]["TELTITOLARE"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
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
        AZIENDE.spAZIENDE_Update();
    }
}