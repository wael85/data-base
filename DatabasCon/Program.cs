using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabasCon
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Animal> mylist = new List<Animal>();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "VetClinic",
                UserID = "wael",
                Password = "1234" +
                "",
                DataSource = "localhost"
            };
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            String select = "select * from Animal";
            SqlCommand cmd = new SqlCommand(select, con);
            // test conection
            using (con)
            {
                if (ConectionTest.IsCon(con))
                {
                    Console.WriteLine("You are conected");
                    con.Open();

                    SqlDataReader Result = cmd.ExecuteReader();




                    while (Result.Read())
                    {
                        Animal a = new Animal();
                        a.PatientID = Result.GetInt32(0);
                        a.Name = Result.GetString(1);
                        a.Type = Result.GetString(2);
                        a.Dob = Result.GetDateTime(3);
                        a.OwnerID = Result.GetInt32(4);
                        mylist.Add(a);

                    }

                    con.Close();
                    foreach (Animal x in mylist)
                    {
                        Console.WriteLine(x.PatientID + " " + x.Name + " " + x.Type + " " + x.Dob + " " + x.OwnerID);
                    }
                }
                else {
                    try { con.Open(); con.Close(); }
                    catch(SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {

                            Console.WriteLine(ex.Errors [i].Message);
                           
                            Console.WriteLine(ex.Errors[i].LineNumber);

                            Console.WriteLine(ex.Errors[i].Source);

                            Console.WriteLine(ex.Errors[i].Number);

                          
                        }
                        
                    }
                    
                }
               

            }

           

        }
    }
}
