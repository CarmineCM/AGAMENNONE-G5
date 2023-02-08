using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsClienti: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClienti_Click(object sender, EventArgs e)
    {
        CLIENTI.RAGIONESOCIALE = txtRS.Text.ToString();
        CLIENTI.spCLIENTI_Insert();
    }
}