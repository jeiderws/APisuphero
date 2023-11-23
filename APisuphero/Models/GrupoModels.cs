using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class GrupoModels
    {
        public GrupoModels(Grupo gp) 
        {
            ID = gp.ID;
            Nombre = gp.Nombre;

            
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
       
    }
}