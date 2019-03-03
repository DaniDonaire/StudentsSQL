using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository;
using StudentSQL.DataAccess.Repository.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.Presentation.Console.Utils
{
    public class Menu
    {
        StudentRepository sr = new StudentRepository();
        DireccionRepository dr = new DireccionRepository();
        PersonaRepository pr = new PersonaRepository();
        Student st = new Student();

        public void InsertDireccionPersona()
        {
            
            bool done = false;
            
            string queryDireccion = "";
            string queryPersona = "";
            //Deberia leer lo que dice el cliente para enviar la query
            done = dr.Insert(queryDireccion);
            if (done)
            {
                pr.Insert(queryPersona);
            }

        }


        public void StudentFunctions()
        {

            sr.Insert();
            sr.SelectAll();
            sr.Select(1);

            //System.Console.WriteLine(st.ToString());
        }
    }
}
