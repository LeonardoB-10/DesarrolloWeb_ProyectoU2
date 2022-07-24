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
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string correo_me { get; set; }
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
        [Required]
        [StringLength(100)]
        [Display(Name = "Password")]
        public string passwod_me { get; set; }
        [Display(Name = "Foto")]
        public byte[] foto_me { get; set; }
    }
}