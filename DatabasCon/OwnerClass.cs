using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasCon
{
    class OwnerClass
    {
        private string tableName = "owner_of";
        private int ownerID;
        private string ownerName;
        private string streetName;
        private int building_number;
        private int floor;
        private int post_number;
        private string city;

        public int Building_number { get; set; }
        public string OwnerName { get; set; }
        public string StreetName { get; set; }
        public int Floor { get; set; }
        public int OwnerID { get; set; }
        public int Post_number { get; set; }
        public string City { get; set; }
        public SqlConnection mycon;
        public void Conect(SqlConnection c)
        {
            mycon = c;
        }
        private List<string> table
            private void InsertNewData()
        {


            try
            {
                mycon.Open();
                int i = cmd.ExecuteNonQuery();
                String ID = cmd.Parameters["@PatientID"].Value.ToString();

                mycon.Close();
                return i;
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {

                    Console.WriteLine(ex.Errors[i].Message);

                    Console.WriteLine(ex.Errors[i].LineNumber);

                    Console.WriteLine(ex.Errors[i].Source);

                    Console.WriteLine(ex.Errors[i].Number);
                }
            }
            return 0;
        }
    }
}
