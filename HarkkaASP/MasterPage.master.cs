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
        days = Int32.Parse(label1.Text) + 1;
        label1.Text = days.ToString();

        List<Resource> prevResources = (List<Resource>)resourceGrid.DataSource;

        //res.IncrementAllResources(prevResources);

        for (int i = 0; i < prevResources.Count; i++)
        {
            if (prevResources[i].isAvailable)
            {
                prevResources[i].value += prevResources[i].increment;
                res.IsResourceMaxed(prevResources[i]);
            }
        }

        resourceGrid.DataSource = prevResources;
        resourceGrid.DataBind();

        //UpdateGridView();
    }

    private void UpdateGridView()
    {
        resourceGrid.DataSource = res.GetAvailableResources();
        resourceGrid.DataBind();
    }
}
