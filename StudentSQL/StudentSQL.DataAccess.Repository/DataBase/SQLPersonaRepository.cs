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
    public class SQLPersonaRepository : IFullCrud
    {
        int done = 0;


        public void Select()
        {
            throw new NotImplementedException();
        }

        public void SelectAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(string connectionString, Persona per)
        {

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Persona (Name, Surname, Dni, IdDireccion) VALUES( @name, @surname, @dni, @iddir)";

                cmd.Parameters.Add("@name", per.Name);
                cmd.Parameters.Add("@surname", per.Surname);
                cmd.Parameters.Add("@dni", per.Dni);
                cmd.Parameters.Add("@iddir", per.DireccionId);

                cmd.ExecuteNonQuery();


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
