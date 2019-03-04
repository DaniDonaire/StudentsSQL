using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository;
using StudentSQL.DataAccess.Repository.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using VuelingLog;

namespace StudentSQL.Presentation.Console.Utils
{

    public class Menu
    {
        ILogger vlog = new Log4Net();


        StudentRepository sr = new StudentRepository();
        DireccionRepository dr = new DireccionRepository();
        PersonaRepository pr = new PersonaRepository();
        Student st = new Student();
        Persona per;
        public void InsertDireccionPersona()
        {

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Direccion dir = new Direccion("calle", "Vila", "BCN");

                    dr.Insert(dir);

                    per = new Persona("Dani", "Go", "555X", dir.DireccionId);

                    pr.Insert(per);
                    scope.Complete();
                }
            }catch (Exception e)
            {
                vlog.Info(e.Message);
                throw;
            }

            Persona persona = new Persona();
            persona = pr.Select(per.PersonaId);

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
