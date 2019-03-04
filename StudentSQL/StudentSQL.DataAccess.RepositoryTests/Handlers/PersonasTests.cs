using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSQL.Common.Library.Models;
using StudentSQL.DataAccess.Repository.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSQL.DataAccess.Repository.Handlers.Tests
{
    [TestClass()]
    public class PersonasTests
    {
        DireccionRepository dr = new DireccionRepository();
        PersonaRepository pr = new PersonaRepository();

        Direccion dir = new Direccion();
        Persona per = new Persona();
        Persona person = new Persona();

        [TestMethod()]
        public void InsertTest()
        {
            dir.Calle = "calle"; dir.Poblacio = "Vila"; dir.Provincia = "BCN";
            dr.Insert(dir);
            per.Name = "Dani"; per.Surname = " G"; per.Dni = "55"; per.DireccionId = dir.DireccionId;
            pr.Insert(per);


            person = pr.Select(per.PersonaId);
            Assert.AreEqual(per.PersonaId, person.PersonaId);
        }
    }
}