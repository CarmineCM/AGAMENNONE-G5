using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GestisciCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void grigliaCommesse_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABASE.DT.Rows.Clear();
        Session["Commesse"] = "";
        if (grigliaCommesse.SelectedValue == null)
        {
            return;
        }
        Session["Commesse"] = grigliaCommesse.SelectedValue;
        // session Commesse per modfica Commesse
    }
}