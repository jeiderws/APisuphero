//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APisuphero.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuperHeroe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuperHeroe()
        {
            this.Heroe_Poder = new HashSet<Heroe_Poder>();
            this.Heroes_Misiones = new HashSet<Heroes_Misiones>();
            this.Grupo = new HashSet<Grupo>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string AñoDebut { get; set; }
        public string PlanetaOrigen { get; set; }
        public string contraseña { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Heroe_Poder> Heroe_Poder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Heroes_Misiones> Heroes_Misiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo> Grupo { get; set; }
    }
}
