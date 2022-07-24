using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class DireccionViewModel
    {
        public int idDireccion { get; set; }

        [Required(ErrorMessage = "Debe ingresar la cédula")]
        [Display(Name = "Cédula")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Debe ingresar una cédula válida")]
        public string cedula_di { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        [Display(Name = "Nombre")]
        [StringLength(50)]
        public string nombre_di { get; set; }

        [Display(Name = "Apellido Paterno")]
        [StringLength(50)]
        [Required(ErrorMessage = "Debe ingresar el apellido paterno")]
        public string apellido_paterno_di { get; set; }

        [Display(Name = "Apellido Materno")]
        [StringLength(50)]
        public string apellido_materno_di { get; set; }

        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string correo_di { get; set; }

        [Display(Name = "Roles")]
        [StringLength(50)]
        [Required]
        public string roles { get; set; }

        [Display(Name = "Teléfono")]
        [StringLength(15)]
        [Required(ErrorMessage = "Debe ingresar el teléfono")]
        public string telefono_di { get; set; }

        [Display(Name = "Ciudad")]
        [StringLength(50)]
        [Required(ErrorMessage = "Debe ingresar la ciudad")]
        public string ciudad_di { get; set; }

        [Display(Name = "Dirección")]
        [StringLength(100)]
        [Required(ErrorMessage = "Debe ingresar la dirección")]
        public string direccion_di { get; set; }

        [Display(Name = "Foto")]
        [DataType(DataType.ImageUrl)]
        [Required]
        public byte[] foto_di { get; set; }

        [Display(Name = "Usuario")]
        [Required]
        public string usuario_di { get; set; }

        [Display(Name = "Contrasenia")]
        [Required]
        public string passwod_di { get; set; }
    }
}