using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LAVORO_InsLavoro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsLavoro_Click(object sender, EventArgs e)
    {
        // controlli formali 
        if (txtDataOra.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // conessione al db

        LAVORI.chiaveCOMMESSA = ddlCommesse.SelectedValue.Trim();
        LAVORI.chiaveDIPENDENTE = ddlDipendenti.SelectedValue.Trim();
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
        // LAVORI.ACCETTAZIONESPESE = 
        LAVORI.spLAVORI_Insert();
    }
}