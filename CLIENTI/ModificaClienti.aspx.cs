using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ModifcaClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Clienti"] == null)
        {
            return;
        }
        string chiavegrigliaClienti = Session["Clienti"].ToString();
        if (string.IsNullOrEmpty(chiavegrigliaClienti))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
            return;
        }
        if (!IsPostBack)
        {
            CLIENTI.chiave = chiavegrigliaClienti;
            CLIENTI.spCLIENTI_SelectByKey();

            txtRS.Text = DATABASE.DT.Rows[0]["RAGIONESOCIALE"].ToString();
            txtIndirizzo.Text = DATABASE.DT.Rows[0]["INDIRIZZO"].ToString();
            txtCitta.Text = DATABASE.DT.Rows[0]["CITTA"].ToString();
            txtCap.Text = DATABASE.DT.Rows[0]["CAP"].ToString();
            txtProvincia.Text = DATABASE.DT.Rows[0]["PROVINCIA"].ToString();
            txtEmail.Text = DATABASE.DT.Rows[0]["EMAIL"].ToString();
            txtTelefono.Text = DATABASE.DT.Rows[0]["TELEFONO"].ToString();
            txtCodiceFiscale.Text = DATABASE.DT.Rows[0]["CODICEFISCALE"].ToString();
            txtIVA.Text = DATABASE.DT.Rows[0]["PIVA"].ToString();
            txtPEC.Text = DATABASE.DT.Rows[0]["PEC"].ToString();
            txtCFE.Text = DATABASE.DT.Rows[0]["CFE"].ToString();
            txtNomeTitolare.Text = DATABASE.DT.Rows[0]["TITOLARE"].ToString();
            txtEmailTitolare.Text = DATABASE.DT.Rows[0]["EMAILTITOLARE"].ToString();
            txtNumeroTitolare.Text = DATABASE.DT.Rows[0]["TELTITOLARE"].ToString();
        }
    }

    protected void btnClienti_Click(object sender, EventArgs e)
    {
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
        CLIENTI.spCLIENTI_Update();
    }
}