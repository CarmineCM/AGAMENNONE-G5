using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LAVORO_ModificaLavoro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Lavoro"] == null)
        {
            return;
        }
        string chiavegrigliaLavoro = Session["Lavoro"].ToString();
        if (string.IsNullOrEmpty(chiavegrigliaLavoro))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
            return;
        }
        if (!IsPostBack)
        {
            LAVORI.chiave = chiavegrigliaLavoro;
            LAVORI.spLAVORI_SelectByKey();

            ddlCommesse.SelectedValue = DATABASE.DT.Rows[0]["chiaveCOMMESSA"].ToString();
            ddlDipendenti.Text = DATABASE.DT.Rows[0]["chiaveDIPENDENTE"].ToString();
            txtDataOra.Text = DATABASE.DT.Rows[0]["DATAORA"].ToString();
            txtOreLavorate.Text = DATABASE.DT.Rows[0]["ORE"].ToString();
            txtDescrizione.Text = DATABASE.DT.Rows[0]["DESCRIZIONE"].ToString();
            txtPernottamento.Text = DATABASE.DT.Rows[0]["PERNOTTAMENTO"].ToString();
            txtPasti.Text = DATABASE.DT.Rows[0]["PASTO"].ToString();
            txtKilometri.Text = DATABASE.DT.Rows[0]["KM"].ToString();
            txtPedaggio.Text = DATABASE.DT.Rows[0]["PEDAGGI"].ToString();
            txtMezzi.Text = DATABASE.DT.Rows[0]["MEZZI"].ToString();
            txtSpeseExtra.Text = DATABASE.DT.Rows[0]["SPESEEXTRA"].ToString();
            txtDescrizioneSpeseExtra.Text = DATABASE.DT.Rows[0]["DESCRIZIONESPESEEXTRA"].ToString();
            ddlAccettazione.SelectedValue = DATABASE.DT.Rows[0]["ACCETTAZIONESPESE"].ToString();
        }
    }

    protected void btnInsLavoro_Click(object sender, EventArgs e)
    {
        LAVORI.chiaveCOMMESSA = ddlCommesse.SelectedValue;
        LAVORI.chiaveDIPENDENTE = ddlDipendenti.SelectedValue;
        LAVORI.DATAORA = txtDataOra.Text.Trim();
        LAVORI.ORE = txtOreLavorate.Text.Trim();
        LAVORI.DESCRIZIONE = txtDescrizione.Text.Trim();
        LAVORI.PERNOTTAMENTO = double.Parse(txtPernottamento.Text.Trim());
        LAVORI.PASTO = double.Parse(txtPasti.Text.Trim());
        LAVORI.KM = txtKilometri.Text.Trim();
        LAVORI.PEDAGGI = double.Parse(txtPedaggio.Text.Trim());
        LAVORI.MEZZI = double.Parse(txtMezzi.Text.Trim());
        LAVORI.SPESEEXTRA = double.Parse(txtSpeseExtra.Text.Trim());
        LAVORI.DESCRIZIONESPESEEXTRA = txtDescrizioneSpeseExtra.Text.Trim();
        LAVORI.ACCETTAZIONESPESE = ddlAccettazione.SelectedValue;
        LAVORI.spLAVORI_Update();
    }
}