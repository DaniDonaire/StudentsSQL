﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.DataAccess.Repository.DataBase.Interfaces
{
    public interface IRead<T>
    {
        T Select(string connection, int id);
        void SelectAll();
    }
}
