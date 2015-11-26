using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HarkkaASP;

public partial class Village : System.Web.UI.Page
{
    BLResource res;
    BLBuilding building;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void gatherFood_Click(object sender, EventArgs e)
    {
        IncrementResource("Food", 1);
    }

    protected void gatherWood_Click(object sender, EventArgs e)
    {
        IncrementResource("Wood", 1);
    }

    private void IncrementResource(string resource, float value)
    {
        LoadSessionResources();
        res.IncrementResource(resource, value);
        Session["Resource"] = res;
    }

    protected void buyHut_Click(object sender, EventArgs e)
    {

    }
    private void LoadSessionResources()
    {
        if (Session["Resource"] != null)
        {
            res = (BLResource)Session["Resource"];
        }
    }
}