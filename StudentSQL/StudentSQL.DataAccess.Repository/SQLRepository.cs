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
                catch (InvalidOperationException e)
                {
                    vlog.Exception(e, e.Message);
                    Console.WriteLine("InvalidOperationException");
                    throw;
                }
                catch (SqlException e)
                {
                    vlog.Exception(e, e.Message);
                    Console.WriteLine("SqlException");
                    throw;
                }
                catch (InvalidCastException e)
                {
                    vlog.Exception(e, e.Message);
                    Console.WriteLine("InvalidCastException");
                    throw;
                }
                catch (System.IO.IOException e)
                {
                    vlog.Exception(e, e.Message);
                    Console.WriteLine("IOException");
                    throw;
                }
            }
            return studentList;
        }

        public Student Insert(string connectionString, Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Student  VALUES(@param1,@param2,@param3,@param4)";

                cmd.Parameters.AddWithValue("@param1", student.StudentId);
                cmd.Parameters.AddWithValue("@param2", student.Name);
                cmd.Parameters.AddWithValue("@param3", student.Surname);
                cmd.Parameters.AddWithValue("@param4", student.Dni);

                cmd.ExecuteNonQuery();

                connection.Close();

            }

            return student;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        
    }
}
