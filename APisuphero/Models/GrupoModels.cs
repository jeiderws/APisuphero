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
            IDSuperHeroe = gp.SuperHeroe.ToList().Select(x => new Superheromodels(x)).ToList();
            IDMisiones = gp.Misiones.ToList().Select(x => new Misionesmodels(x)).ToList();
            
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List < Superheromodels> IDSuperHeroe { get; set; }
        public List < Misionesmodels> IDMisiones { get; set; }
    }
}