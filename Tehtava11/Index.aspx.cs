using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

public partial class Index : System.Web.UI.Page
{
    
    public string path = HttpContext.Current.Server.MapPath("~/App_Data/palautteet.xml");

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBoxPvm.Text = DateTime.Today.ToShortDateString();
        TextBoxPvm.Enabled = false;

        
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            XDocument doc = XDocument.Load(path);
            XElement root = doc.Element("palautteet");
            IEnumerable<XElement> rows = root.Descendants("palaute");
            XElement firstRow = rows.First();

            firstRow.AddBeforeSelf(
                new XElement("palaute",
                new XElement("pvm", TextBoxPvm.Text),
                new XElement("tekija", TextName.Text),
                new XElement("kurssi", TextCourse.Text),
                new XElement("opittu", TextAreaLearned.Text),
                new XElement("haluanoppia", TextAreaWant.Text),
                new XElement("hyvaa", TextAreaGood.Text),
                new XElement("parannettavaa", TextAreaImprovement.Text),
                new XElement("muuta", TextAreaOther.Text)
                ));
            doc.Save(path);
        }
    }

    protected void buttonShow_Click(object sender, EventArgs e)
    {

    }
}