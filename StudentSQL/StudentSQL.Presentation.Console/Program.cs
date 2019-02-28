using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSQL.DataAccess.Repository;

namespace StudentSQL.Presentation.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentRepository sr = new StudentRepository();
            sr.Test();


            System.Console.ReadLine();

        }
    }
}
