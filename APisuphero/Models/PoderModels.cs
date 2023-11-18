using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class PoderModels
    {
        public PoderModels( Poder pd) 
        {
             ID = pd.ID;
            Nombre = pd.Nombre;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}