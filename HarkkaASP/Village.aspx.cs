using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HarkkaASP;

public partial class Village : System.Web.UI.Page
{
    BLResource res = new BLResource();
    BLBuilding building = new BLBuilding();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private void LoadSesionVariables()
    {
        LoadSessionResources();
        LoadSessionBuildings();
    }

    private void LoadSessionResources()
    {
        if (Session["Resource"] != null)
        {
            res = (BLResource)Session["Resource"];
        }
    }

    private void LoadSessionBuildings()
    {
        if(Session["Building"] != null)
        {
            building = (BLBuilding)Session["Buildings"];
        }
    }

    private void SaveSessionVariables()
    {
        Session["Resource"] = res;
        Session["Building"] = building;
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
        res.AddResource(resource, value);
        Session["Resource"] = res;
    }

    protected void buyHut_Click(object sender, EventArgs e)
    {
        BuyBuilding("Hut");
        buyHut.Text = "Hut - " + building.GetBuilding("Hut").amount;
    }

    public void BuyBuilding(String buildingName)
    {
        LoadSessionResources();
        if (building.IsRequirementsMetForBuilding(buildingName, res))
        {
            res = building.BuyBuilding(buildingName, res);
            Session["Resource"] = res;
            Session["Building"] = building;
        }
    }

    protected void buyOutpost_Click(object sender, EventArgs e)
    {
        BuyBuilding("Hunt copse");
    }
}