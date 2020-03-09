using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DatabasCon
{
    static class ConectionTest
    {
        public static bool IsCon(this SqlConnection con)
        {
            try
            {
                con.Open();
                con.Close();
            }
            catch (SqlException )
            {
                return false;

            } { return true; }
        }
    }
}
