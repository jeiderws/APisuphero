using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class Superheromodels
    {
        public Superheromodels( SuperHeroe sp) 
        {
            ID = sp.ID;
            Nombre = sp.Nombre;
            AñoDebut = sp.AñoDebut;
            PlanetaOrigen = sp.PlanetaOrigen;
            contraseña = sp.contraseña;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string AñoDebut { get; set; }
        public string PlanetaOrigen { get; set; }
        public string contraseña { get; set; }
    }
}