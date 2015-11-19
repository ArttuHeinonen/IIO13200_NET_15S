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
    public BLResource res;
    

    protected void PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Normal";
        res = new BLResource();
        DataTable dt = res.GetResources();
        //grid.DataSource = 
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int i = Int32.Parse(label1.Text) + 1;
        label1.Text = i.ToString();
    }
}
