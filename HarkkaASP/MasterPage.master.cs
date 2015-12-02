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
    BLResource res = new BLResource();
    int days;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Normal";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadSessionVariables();
        UpdateGridView();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        LoadSessionResources();
        LoadSessionDays();

        days++;
        label1.Text = days.ToString();

        res.IncrementAllResources();

        SaveSessionVariables();

        UpdateGridView();
    }

    private void UpdateGridView()
    {
        resourceGrid.DataSource = res.GetAvailableResources();
        resourceGrid.DataBind();
    }

    private void SaveSessionVariables()
    {
        Session["Resource"] = res;
        Session["Day"] = days;
    }

    public void LoadSessionVariables()
    {
        LoadSessionResources();
        LoadSessionDays();
        label1.Text = days.ToString();
    }

    public void LoadSessionResources()
    {
        if (Session["Resource"] != null)
        {
            res = (BLResource)Session["Resource"];
        }
    }

    public void LoadSessionDays()
    {
        if (Session["Day"] != null)
        {
            days = (Int32)Session["Day"];
        }
    }
}
