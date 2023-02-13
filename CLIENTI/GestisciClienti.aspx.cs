using System;

public partial class GestisciClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void grigliaClienti_SelectedIndexChanged(object sender, EventArgs e)
    {
        DATABASE.DT.Rows.Clear();
        Session["Clienti"] = "";
        if (grigliaClienti.SelectedValue == null)
        {
            return;
        }
        Session["Clienti"] = grigliaClienti.SelectedValue;
        // session clienti per modfica clienti
    }
}