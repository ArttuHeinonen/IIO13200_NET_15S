using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HarkkaASP;

public partial class Options : System.Web.UI.Page
{
    BLResource res = new BLResource();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["Resource"] != null)
        {
            res = (BLResource)Session["Resource"];
        }
        res.ResetResourceValues();

        Session["Day"] = 0;
        Session["Resource"] = res;
    }
}