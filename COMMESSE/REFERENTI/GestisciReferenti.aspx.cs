using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grigliaReferenti_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABASE.DT.Rows.Clear();
        Session["Referenti"] = "";
        if (grigliaReferenti.SelectedValue == null)
        {
            return;
        }
        Session["Referenti"] = grigliaReferenti.SelectedValue.ToString();
        // session Referenti per modfica referenti
    }
}