using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class CitasViewModel
    {
        public int idCita { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Debe ingresar la fecha")]
        public DateTime fecha { get; set; }
        [Display(Name = "Hora")]
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Debe ingresar la hora")]
        public TimeSpan hora { get; set; }
        [Display(Name = "Paciente")]
        [StringLength(10)]
        [Required(ErrorMessage = "Debe ingresar cedula de paciente")]
        public string cedula_pte { get; set; }
        [Display(Name = "Doctor")]
        [StringLength(10)]
        [Required(ErrorMessage = "Debe ingresar cedula de doctor")]
        public string cedula_med { get; set; }
    }
}