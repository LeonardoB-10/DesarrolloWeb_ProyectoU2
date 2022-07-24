//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoU2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class medico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medico()
        {
            this.cita = new HashSet<cita>();
        }
    
        public string cedula_me { get; set; }
        public string nombre_me { get; set; }
        public string apellido_paterno_me { get; set; }
        public string apellido_materno_me { get; set; }
        public string correo_me { get; set; }
        public Nullable<System.DateTime> fNacimiento_me { get; set; }
        public Nullable<int> edad_me { get; set; }
        public string telefono_me { get; set; }
        public string ciudad_me { get; set; }
        public string direccion_me { get; set; }
        public byte[] foto_me { get; set; }
        public string passwod_me { get; set; }
        public Nullable<int> idEpecialidad { get; set; }
        public Nullable<int> idHorario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cita> cita { get; set; }
        public virtual especialidad especialidad { get; set; }
        public virtual horario horario { get; set; }
    }
}
