using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class Misionesmodels
    {
        public Misionesmodels(Misiones ms) 
        {
            ID = ms.ID;
            Descripcion = ms.Descripcion;
            IDTipo = new TipoMisionmodels(ms.TipoMision); 
        }
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public TipoMisionmodels IDTipo { get; set; }

    }
}