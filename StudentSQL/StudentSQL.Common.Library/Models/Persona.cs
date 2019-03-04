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
        public string Dni { get; set; }
        public int DireccionId { get; set; }


        public Persona(string n, string s, string dni, int idd)
        {
            Name = n;
            Surname = s;
            Dni = dni;
            DireccionId = idd;
        }

        public Persona() { }
    }
}
