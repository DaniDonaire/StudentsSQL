using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.Common.Library.Models
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public string Provincia { get; set; }
        public string Poblacio { get; set; }
       
    }
}
