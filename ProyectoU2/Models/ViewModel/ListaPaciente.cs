using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class ListaPaciente
    {
        public int idPaciente { get; set; }
        public string cedula_pte { get; set; }
        public string nombre_pte { get; set; }
        public string apellido_paterno_pte { get; set; }
        public string apellido_materno_pte { get; set; }
        public string correo_pte { get; set; }
        public string fNacimiento_pte { get; set; }
        public int edad_pte { get; set; }
        public string ftelefono_pte { get; set; }
        public string ciudad_pte { get; set; }
        public string direccion_pte { get; set; }
        public byte[] foto_pte { get; set; }
        public string usuario_pte { get; set; }
        public string passwod_pte { get; set; }

    }
}