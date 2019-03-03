using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository;
using StudentSQL.DataAccess.Repository.Handlers;
using StudentSQL.Presentation.Console.Utils;

namespace StudentSQL.Presentation.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {



            Menu m = new Menu();

            m.InsertDireccionPersona();
            


            System.Console.ReadLine();

        }
    }
}
