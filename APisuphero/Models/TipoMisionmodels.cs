using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class TipoMisionmodels
    {
        public TipoMisionmodels( TipoMision tpm) 
        {
            ID = tpm.ID;
            Nombre = tpm.Nombre;    
        }
        public int ID { get; set; }
        public string Nombre { get; set; }

    }
}