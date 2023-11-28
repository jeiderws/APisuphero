using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APisuphero.Models
{
    public class LoguinRespuesta
    {
        public String Token { get; set; }
        public Superheromodels User { get; set; }
        public DateTime DateTime { get; set; }
        public Boolean sucees { get; set; }
    }
}