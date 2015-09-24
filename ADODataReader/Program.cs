using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Console.Title = "ADODataReader";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
