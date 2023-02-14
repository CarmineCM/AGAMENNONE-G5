using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // controlli formali 

        if (txtInserisciCorpoOra.Text.Trim() == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Dati mancanti.');", true);
            return;
        }

        // conessione al db

        //COMMESSE.chiaveCLIENTE =
        //COMMESSE.chiaveRESPONSABILE =
        //COMMESSE.CORPOORA =
        //COMMESSE.DATAAPERTURA =
        //COMMESSE.DATACHIUSURA =
        //COMMESSE.DATACONSEGNA =
        //COMMESSE.DESCRIZIONE =
        //COMMESSE.IMPORTOCORPO =
        //COMMESSE.IMPORTOORARIO =
        //COMMESSE.ANTICIPO =
        //COMMESSE.PERNOTTAMENTO =
        //COMMESSE.PASTO =
        //COMMESSE.KM =
        //COMMESSE.PEDAGGI =
        //COMMESSE.MEZZI =
    }
}