using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HarkkaASP;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public BLResource res = new BLResource();
    public BLBuilding building = new BLBuilding();
    public int days;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Normal";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        UpdateGridView();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        res.res = (List<Resource>)resourceGrid.DataSource;
        days = Int32.Parse(label1.Text) + 1;
        label1.Text = days.ToString();

        res.IncrementAllResources();

        UpdateGridView();
    }

    private void UpdateGridView()
    {
        resourceGrid.DataSource = res.GetAvailableResources();
        resourceGrid.DataBind();
    }
}
