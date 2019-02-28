using StudentSQL.Common.Library.Models;
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


        public List<Student> Select(string connectionString, string query)
        {
            List<Student> studentList = new List<Student>();

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
                            Student st = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

                            studentList.Add(st);
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
            return studentList;
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
