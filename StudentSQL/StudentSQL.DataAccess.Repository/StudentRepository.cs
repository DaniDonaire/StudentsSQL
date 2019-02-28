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

    public class StudentRepository
    {
        string connectionString = "Data Source = localhost;" +
            "Initial Catalog=Vueling;" +
            "Integrated Security=SSPI;";

        SQLRepository SQLM = new SQLRepository();


        public List<Student> SelectAll()
        {
            string query = "SELECT * FROM Student;";
            List<Student> listStudents = new List<Student>();
            listStudents = SQLM.Select(connectionString, query);

            return listStudents;
        }

         
        public Student Select(int idStudent)
        {
            string query = String.Concat("SELECT * FROM Student WHERE StudentId=",idStudent.ToString());
            List<Student> listStudents = new List<Student>();
            listStudents = SQLM.Select(connectionString, query);

            return listStudents.First();
        }

        public void Insert()
        {
            Student st = new Student(2, "Dani2", "test", "324q4");
            SQLM.Insert(connectionString, st);

        }


    }
}
