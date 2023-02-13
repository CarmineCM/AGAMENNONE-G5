using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsDipendente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDipendente_Click(object sender, EventArgs e)
    {
        // controlli formali 
        if(txtEMail.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // connessione al db

        DIPENDENTI.chiaveAZIENDA = ddlAzienda.Text.Trim();
        DIPENDENTI.EMAIL = txtEMail.Text.Trim();
        DIPENDENTI.PWD = txtPwd.Text.Trim();
        DIPENDENTI.ABILITATO = ddlAbilita.SelectedValue;
        DIPENDENTI.PRIMOACCESSO = ddlPrimoAccesso.SelectedValue;
        DIPENDENTI.RUOLO = ddlRuolo.Text.Trim(); 
        DIPENDENTI.COGNOME = txtCognome.Text.Trim();    
        DIPENDENTI.NOME = txtNome.Text.Trim();
        DIPENDENTI.INDIRIZZO = txtIndirizzo.Text.Trim();
        DIPENDENTI.CITTA = txtCitta.Text.Trim();
        DIPENDENTI.CAP = txtCap.Text.Trim();
        DIPENDENTI.PROVINCIA = txtProvincia.Text.Trim();
        DIPENDENTI.TELEFONO = txtTelefono.Text.Trim();
        DIPENDENTI.COSTOORARIO = txtCostoOrario.Text.Trim();
        DIPENDENTI.DATAINIZIORAPPORTO = txtDataInizio.Text.Trim();
        DIPENDENTI.DATAFINERAPPORTO = txtDataFine.Text.Trim();
        DIPENDENTI.spDIPENDENTI_Insert();
    }
}