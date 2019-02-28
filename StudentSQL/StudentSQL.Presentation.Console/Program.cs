using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository;

namespace StudentSQL.Presentation.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentRepository sr = new StudentRepository();
            Student st = new Student();

            sr.SelectAll();
            st = sr.Select(1);

            System.Console.WriteLine(st.ToString());
            System.Console.ReadLine();

        }
    }
}
