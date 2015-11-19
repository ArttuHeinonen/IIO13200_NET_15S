using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoEFNewCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        //Luodaan uusi entiteetti kokoelmaan ja tallennetaan muutos kantaan
        
        try
        {
            //Pöljän pojan tarkistus että kaikissa kentissä on arvot
            if(txtFirstName.Text.Length * txtLastName.Text.Length * txtAddress.Text.Length * txtZIP.Text.Length * txtCity.Text.Length != 0)
            {
                ViiniEntities ctx = new ViiniEntities();
                customer uusi = new customer();
                uusi.Firstname = txtFirstName.Text;
                uusi.Lastname = txtLastName.Text;
                uusi.Address = txtAddress.Text;
                uusi.ZIP = txtZIP.Text;
                uusi.City = txtCity.Text;
                //Lisätään kontekstiin
                ctx.customers.Add(uusi);
                //Tallennetaan kantaan
                ctx.SaveChanges();
                lblMessage.Text = string.Format("Uusi asiakas {0} lisätty kantaan", uusi.Firstname + " " + uusi.Lastname);
            }
            else
            {
                lblMessage.Text = "Tarkista kentät, jotain puuttuu";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
            throw;
        }
    }
}