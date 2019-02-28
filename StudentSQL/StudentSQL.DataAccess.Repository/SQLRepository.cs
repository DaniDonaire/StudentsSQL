using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingLog;

namespace StudentSQL.DataAccess.Repository
{
    public class SQLRepository
    {

        ILogger vlog = new Log4Net();


        public void Select(string connectionString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetInt32(0),
                                reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();

                }
                catch
                {
                    vlog.Info("Cant find bbdd");
                    Console.WriteLine("Fail");
                }
            }
        }

        public void Insert()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
