using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoxOy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ladataan asiakkaan tiedot tietokannasta
        GetRealData();
    }

    protected void GetDemoData()
    {
        //Täytetään GridView
        DataTable dt = JAMK.IT.DBDemoxOy.GetDataSimple();
        gvCustomers.DataSource = dt;
        gvCustomers.DataBind();
    }

    protected void GetRealData()
    {
        try
        {
            DataTable dt = JAMK.IT.DBDemoxOy.GetDataReal();
            gvCustomers.DataSource = dt;
            gvCustomers.DataBind();
        }
        catch (Exception ex)
        {
            lblNotes.Text = ex.Message;
        }
        
    }
}