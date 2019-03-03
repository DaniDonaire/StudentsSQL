using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.DataAccess.Repository.Handlers
{
    public class DireccionRepository 
    {
        SQLDireccionRepository SQLdr = new SQLDireccionRepository();
        string connectionString = "Data Source = localhost; Initial Catalog=Vueling; Integrated Security=SSPI;";

        public bool Insert(Direccion direccion)
        {
            return SQLdr.Insert(connectionString, direccion);
        }


    }
}
