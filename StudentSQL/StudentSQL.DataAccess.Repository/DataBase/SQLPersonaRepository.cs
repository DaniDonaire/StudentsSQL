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
    public class SQLPersonaRepository : IFullCrud, IRead<Persona>, ICreate<Persona>
    {
        int done = 0;


        public Persona Select(string connectionString, int id)
        {
            Persona persona = new Persona();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Persona WHERE IdPersona=@id;";
                cmd.Parameters.Add("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        persona.PersonaId = reader.GetInt32(0);
                        persona.Name = reader.GetString(1);
                        persona.Surname = reader.GetString(2);
                        persona.Dni = reader.GetString(3);
                        persona.DireccionId = reader.GetInt32(4);
                        
                    }
                }


                
                return persona;

            }
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
                cmd.CommandText = "INSERT INTO Persona (Name, Surname, Dni, IdDireccion) VALUES( @name, @surname, @dni, @iddir);SELECT CAST(SCOPE_IDENTITY() AS INT);";

                cmd.Parameters.Add("@name", per.Name);
                cmd.Parameters.Add("@surname", per.Surname);
                cmd.Parameters.Add("@dni", per.Dni);
                cmd.Parameters.Add("@iddir", per.DireccionId);

                //cmd.ExecuteNonQuery();

                per.PersonaId = (int)cmd.ExecuteScalar();

                return true;
                

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
