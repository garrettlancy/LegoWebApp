using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lego.Models;
using System.Data.SqlClient;

namespace Lego.DAL
{
    public class LegoSetDAL
    {

        public List<LegoSet> GetSets()
        {
            List<LegoSet> output = new List<LegoSet>();

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LegoDb;Integrated Security=True"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Sets;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        LegoSet set = new LegoSet();
                        set.Name = Convert.ToString(reader["name"]);
                        set.Description = Convert.ToString(reader["description"]);
                        set.Pieces = Convert.ToInt32(reader["pieces"]);
                        set.ImageName = Convert.ToString(reader["imageName"]);

                        output.Add(set);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }

    }
}