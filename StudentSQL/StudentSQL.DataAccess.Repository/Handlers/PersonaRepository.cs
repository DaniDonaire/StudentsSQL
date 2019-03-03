using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.DataAccess.Repository.Handlers
{


    public class PersonaRepository
    {

        SQLPersonaRepository SQLpr = new SQLPersonaRepository();
        string connectionString = "Data Source = localhost; Initial Catalog=Vueling; Integrated Security=SSPI;";
        DireccionRepository dr = new DireccionRepository();


        public bool Insert(Persona per)
        {
            bool done;

            return SQLpr.Insert(connectionString, per);

            
            
        }
    }
}
