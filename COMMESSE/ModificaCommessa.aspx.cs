using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaCommessa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Commesse"] == null)
        {
            return;
        }
        string chiavegrigliaCommesse = Session["Commesse"].ToString();
        if (string.IsNullOrEmpty(chiavegrigliaCommesse))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "ERRORE", "alert('Nessun elemento selezionato');", true);
            return;
        }
        if (!IsPostBack)
        {
            COMMESSE.chiave = chiavegrigliaCommesse;
            COMMESSE.spCOMMESSE_SelectByKey();

            //txtModificaCorpoOra = DATABASE.DT.Rows[0]["CORPOORA"].ToString();
            //calendarDataApertura = DATABASE.DT.Rows[0]["DATAAPERTURA"].ToString();
        }
    }
}