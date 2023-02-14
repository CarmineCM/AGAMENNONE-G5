using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        liReferenti.Visible = false;
        liDipendenti.Visible = false;
        liAziende.Visible = false;
        liReport.Visible = false;
        liAccessi.Visible = false;
        liEventi.Visible = false;
        lblUtente.Text = Session["EMAIL"].ToString();
        if (Session["RUOLO"].ToString() == "A")
        {
            liReferenti.Visible = true;
            liDipendenti.Visible = true;
            liAziende.Visible = true;
            liReport.Visible = true;
            liAccessi.Visible = true;
            liEventi.Visible = true;
            return;
        }
        if (Session["RUOLO"].ToString() == "O")
        {
            liReferenti.Visible = true;
            liDipendenti.Visible = true;
            liAziende.Visible = true;
            liAccessi.Visible = true;
            return;
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //refresho la session e mando alla schermata di login
        Session["EMAIL"] = "";
        Session["RUOLO"] = "";
        Response.Redirect("Login.aspx");
    }
}
