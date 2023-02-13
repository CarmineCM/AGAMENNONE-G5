using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GesioneLavoro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grigliaLavoro_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABASE.DT.Rows.Clear();
        Session["Lavoro"] = "";
        if (grigliaLavoro.SelectedValue == null)
        {
            return;
        }
        Session["Lavoro"] = grigliaLavoro.SelectedValue;
        // session Lavoro per modfica lavoro
    }
}