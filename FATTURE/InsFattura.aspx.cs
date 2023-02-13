using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsFattura : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // controlli formali 
        if (txtDataFattura.Text.Trim() == "" || txtImporto.Text.Trim() == "" || txtAliquota.Text.Trim() == "" || txtDescrizione.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // conessione al db
        FATTURE.chiaveCOMMESSA = ddlCommesssa.Text.Trim();
        FATTURE.NUMEROFATTURA = txtNumeroFattura.Text.Trim();
        FATTURE.DATAFATTURA = txtDataFattura.Text.Trim();
        FATTURE.IMPORTO = txtImporto.Text.Trim();
        FATTURE.ALIQUOTA = txtAliquota.Text.Trim();
        FATTURE.DESCRIZIONE = txtDescrizione.Text.Trim();
        FATTURE.DATASALDO = txtDataSaldo.Text.Trim();
        FATTURE.spFATTURE_Insert();
    }
}