using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoEF : System.Web.UI.Page
{
    ViiniEntities ctx; //Tässä on kaikki db:n tiedot ja entiteettikokeilmina
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ladataan vain kerran
        if (!IsPostBack)
        {
            FillControls();
        }
    }

    protected void FillControls()
    {
        //Täytetään kontrollit ctx-tiedoilla.
        ctx = new ViiniEntities();
        var query = (from c in ctx.customers orderby c.City select c.City).Distinct();
        ddlCities.DataSource = query.ToList();
        ddlCities.DataBind();

    }

    protected void btnGetAllCustomers_Click(object sender, EventArgs e)
    {
        //Haetaan kaikki asiakkaat LINQ-kyselyllä
        ctx = new ViiniEntities();
        var query = from c in ctx.customers select c;
        //kyselyn tulos sidotaan datakontrolliin
        gvData.DataSource = query.ToList();
        gvData.DataBind();
    }

    protected void btnGetCustomersFromCity_Click(object sender, EventArgs e)
    {
        //Haetaan kaikki asiakkaat valitusta kaupungista LINQ:lla
        ctx = new ViiniEntities();
        var query = from c in ctx.customers where c.City.StartsWith(ddlCities.SelectedValue.ToString()) select c;
        //kyselyn tulos sidotaan datakontrolliin
        gvData.DataSource = query.ToList();
        gvData.DataBind();
    }

    protected void btnGetSortedCustomers_Click(object sender, EventArgs e)
    {
        //Näytetään kunkin kaupungin asiakkat, käytetään HTML:ää
        //Ensin tyhjennetään datagrid
        gvData.DataSource = null;
        gvData.DataBind();
        //LINQ kyselyssä luodaan lennosta uusi entiteetti asiakkaan tiedoista
        ctx = new ViiniEntities();
        var query = from c in ctx.customers orderby c.City select new { Etunimi = c.Firstname, Sukunimi = c.Lastname, Kaupunki = c.City };
        string group = "";
        foreach (var a in query)
        {
            if(group == a.Kaupunki)
            {
                tulos.InnerHtml += a.Etunimi + " " + a.Sukunimi + "<br/>";
            }
            else
            {
                tulos.InnerHtml += "<h3>" + a.Kaupunki + "</h3>";
                tulos.InnerHtml += a.Etunimi + " " + a.Sukunimi + "<br/>";
                group = a.Kaupunki;
            }
        }
    }
}