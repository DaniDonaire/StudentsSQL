using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.Common.Library.Models
{
    public class Student
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }


        public Student()
        {

        }

        public Student(int id, string name, string surname, string dni)
        {
            StudentId = id;
            Name = name;
            Surname = surname;
            Dni = dni;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}",this.StudentId, this.Name, this.Surname, this.Dni);
        }

    }
}
