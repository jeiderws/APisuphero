using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class HeroPoderModels
    {
        public HeroPoderModels( Heroe_Poder hp)
        {
          IDHeroe = hp.IDHeroe;
            IDPoder = hp.IDPoder;
            Poder = hp.Poder;
            SuperHeroe = hp.SuperHeroe;
        }
        public int IDPoder { get; set; }
        public int IDHeroe { get; set; }
        public  Poder Poder { get; set; }
        public  SuperHeroe SuperHeroe { get; set; }
    }
}