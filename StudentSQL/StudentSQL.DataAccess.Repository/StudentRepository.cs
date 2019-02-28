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
        
        public void SelectAll()
        {
            string query = "SELECT * FROM Student;";
            SQLRepository SQLM = new SQLRepository();
            SQLM.Select(connectionString, query);
        }

         
        public void Select(int idStudent)
        {
            string query = String.Concat("SELECT * FROM Student WHERE StudentId=",idStudent.ToString());
            SQLRepository SQLM = new SQLRepository();
            SQLM.Select(connectionString, query);
        }


    }
}
