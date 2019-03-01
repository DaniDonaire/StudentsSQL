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


        public void SelectAll()
        {
            string query = "SELECT * FROM Student;";
            //List<Student> listStudents = new List<Student>();
            SQLM.Select(connectionString, query);
        
        }

         
        public void Select(int idStudent)
        {
            string query = String.Concat("SELECT * FROM Student WHERE StudentId=",idStudent.ToString());
            List<Student> listStudents = new List<Student>();
            //SQLM.Select(connectionString, query);

        }

        public void Insert()
        {
            Student st = new Student(5, "Dani2", "test", "324q4");

            string query = String.Concat("INSERT INTO Student  VALUES(",st.StudentId,", '",st.Name,"', '",st.Surname,"', '",st.Dni,"');");

            SQLM.Insert(connectionString, query);

        }


    }
}
