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

        public bool Insert(string connectionString, string query)
        {

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = query;
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
