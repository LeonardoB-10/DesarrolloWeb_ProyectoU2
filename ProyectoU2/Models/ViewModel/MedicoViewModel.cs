using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class MedicoViewModel
    {

        [Required]
        [StringLength(10)]
        [Display(Name = "Cedula")]
        public string cedula_me { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Nombre")]
        public string nombre_me { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "ApellidoPaterno")]
        public string apellido_paterno_me { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "ApellidoMaterno")]
        public string apellido_materno_me { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string correo_me { get; set; }
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fNacimiento_me { get; set; }
        [Required]
        [Display(Name = "Edad")]
        public int edad_me { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Telefono")]
        public string telefono_me { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Ciudad")]
        public string ciudad_me { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Dirección")]
        public string direccion_me { get; set; }
        [Display(Name = "Foto")]
        public byte[] foto_me { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Password")]
        public string passwod_me { get; set; }
        [Required]
        [Display(Name = "idEspecialidad")]
        public int idEspecialidad { get; set; }
        [Required]
        [Display(Name = "idHorario")]
        public int idHorario { get; set; }

    }
}