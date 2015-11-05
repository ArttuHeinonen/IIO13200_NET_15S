using Harkka;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    
    public BLResource res;

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = res.GetResources();
        //grid.DataSource = 
    }


    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int i = Int32.Parse(label1.Text) + 1;
        label1.Text = i.ToString();
    }
}