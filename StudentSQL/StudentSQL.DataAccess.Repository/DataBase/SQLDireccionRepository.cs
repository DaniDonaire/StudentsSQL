using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository.DataBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.DataAccess.Repository.DataBase
{
    public class SQLDireccionRepository : IFullCrud, ICreate<Direccion>
    {
        int done = 0;

        public void Select(string connection, int id)
        {
            throw new NotImplementedException();
        }

        public void SelectAll()
        {
            throw new NotImplementedException();
        }


        public bool Insert(string connectionString, Direccion dir)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO Direccion (Calle, Provincia, Poblacion) VALUES( @calle, @prov, @pobl);SELECT CAST(SCOPE_IDENTITY() AS INT)";

                cmd.Parameters.Add("@calle", dir.Calle);
                cmd.Parameters.Add("@prov", dir.Provincia);
                cmd.Parameters.Add("@pobl", dir.Poblacio);

                dir.DireccionId = (int)cmd.ExecuteScalar();
                return true;
                //done = cmd.ExecuteNonQuery();

                if (done < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }

        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
