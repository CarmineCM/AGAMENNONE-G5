using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class COMMESSE_ModificaRefente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Referenti"] == null)
        {
            return;
        }
        string chiavegrigliaReferenti = Session["Referenti"].ToString();
        if (string.IsNullOrEmpty(chiavegrigliaReferenti))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
            return;
        }
        if (!IsPostBack)
        {
            REFERENTI.chiave = chiavegrigliaReferenti;
            REFERENTI.spREFERENTI_SelectByKey();
            //ddlClienti.SelectedValue = DATABASE.DT.Rows[0]["chiaveCLIENTE"].ToString();
            txtCognome.Text = DATABASE.DT.Rows[0]["COGNOME"].ToString();
            txtNome.Text = DATABASE.DT.Rows[0]["NOME"].ToString();
            txtEmail.Text = DATABASE.DT.Rows[0]["EMAIL"].ToString();
            txtTelefono.Text = DATABASE.DT.Rows[0]["TELEFONO"].ToString();
        }
    }
}