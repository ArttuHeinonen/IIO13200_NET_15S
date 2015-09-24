using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sovellus hakee SQL Serverilta DemoxOy-tietokannasta lasnaolt-taulusta kaikki tietuteet
namespace ADODataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            LubricateConsole();
            //GetData_DataReader();
            GetData_DataTable();
        }
        static void LubricateConsole()
        {
            Console.Title = "ADODataReader";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        static void GetData_DataTable()
        {
            //UI-kerros data esittämistä varten
            try
            {
                //Heataan data DataTablen avulla
                DataTable dt = GetDataReal();
                string rivi = "";
                //Loopitetaan DataTablen rivin läpi
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        rivi += dr[dc].ToString() + " ";
                    }
                    Console.WriteLine(rivi);
                    rivi = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static DataTable GetDataSimple()
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

        static DataTable GetDataReal()
        {
            //DBkerros, haetaan DemoxOy-tietokannasta taulun lasnaolot tietueet, palauttaa DataTablen
            string sql = "SELECT asioid, lastname, firstname, date FROM lasnaolot";// WHERE asioid='H3425'";
            string connStr = @"Data source=eight.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari13";
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

        static void GetData_DataReader()
        {     
            try
            {
                string sql = "SELECT asioid, lastname, firstname, date FROM lasnaolot WHERE asioid='H3425'";
                string connStr = @"Data source=eight.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari13";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //Avataan yhteys
                    conn.Open();
                    //Luodaan komento = command-olio
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        //Luodaan Reader
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            //Käydään rdr läpi
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    Console.WriteLine("{0}\t{1} {2} {3}", rdr.GetString(0), rdr.GetString(2), rdr.GetString(1), rdr.GetDateTime(3));
                                }
                            }
                            else
                            {
                                Console.WriteLine("Tietueita ei ole olemassa.");
                            }
                            //Suljetaan rdr
                            rdr.Close();
                        }
                    }
                    conn.Close();
                    Console.WriteLine("Tietokantayhteys syljettu onnistuneesti.");
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
