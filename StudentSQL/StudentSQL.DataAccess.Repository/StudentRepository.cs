using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingLog;

namespace StudentSQL.DataAccess.Repository
{

    public class StudentRepository
    {
        ILogger vlog = new Log4Net();


        public void Test()
        {
            Console.WriteLine("Say");
            vlog.Info("Test 2");
        }

    }
}
