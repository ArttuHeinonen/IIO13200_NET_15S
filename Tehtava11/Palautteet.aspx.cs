using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Palautteet : System.Web.UI.Page
{
    public string path = HttpContext.Current.Server.MapPath("~/App_Data/palautteet.xml");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            gv.DataSource = ds;
            gv.DataBind();
        }
    }
}