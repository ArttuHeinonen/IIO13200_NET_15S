using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tehtava5
{
    public static class DBDemoxOy
    {



        public static DataTable GetDataSimple()
        {
            DataTable dt = new DataTable();
            //Sarakkeet
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            //Rivit
            dt.Rows.Add("Kalle", "Isokallio");
            dt.Rows.Add("Matt", "Majula");

            return dt;
        }

        public static DataTable GetDataReal()
        {
            //DBkerros, haetaan DemoxOy-tietokannasta taulun lasnaolot tietueet, palauttaa DataTablen
            string sql = "SELECT asioid, lastname, firstname, date FROM lasnaolot";// WHERE asioid='H3425'";
            return GetData(sql);
        }

        public static DataTable GetDataFiltered(String filter)
        {
            //DBkerros, haetaan DemoxOy-tietokannasta taulun lasnaolot tietueet, palauttaa DataTablen
            string sql = "SELECT asioid, lastname, firstname, date FROM lasnaolot WHERE asioid='" + filter + "'";
            return GetData(sql);
        }

        public static DataTable GetData(String sql)
        {
            string connStr = Tehtava5.Properties.Settings.Default.connection.ToString();
            //string connStr = @"Data source=eight.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari13";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //Avataan yhteys
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "lasnaolot");
                        conn.Close();
                        return ds.Tables["lasnaolot"];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
