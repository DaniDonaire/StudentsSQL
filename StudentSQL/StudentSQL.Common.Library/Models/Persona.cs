using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.Common.Library.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Dni { get; set; }
        public int DireccionId { get; set; }
    }
}
