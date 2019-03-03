using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.DataAccess.Repository.DataBase.Interfaces
{
    public interface ICreate <T>
    {
        bool Insert(string connection, T model);
    }
}
