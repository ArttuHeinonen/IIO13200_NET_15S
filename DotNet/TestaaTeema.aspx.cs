using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestaaTeema : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        switch (Request.QueryString["theme"])
        {
            case "Simppeli":
                Page.Theme = "Simppeli";
                break;
            case "Punainen":
                Page.Theme = "Punainen";
                break;
            default:
                break;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}