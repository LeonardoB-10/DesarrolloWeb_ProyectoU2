using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class ListaMedico
    {
        public string cedula_me { get; set; }
        public string nombre_me { get; set; }
        public string apellido_paterno_me { get; set; }
        public string apellido_materno_me { get; set; }
        public string correo_me { get; set; }
        public string fNacimiento_me { get; set; }
        public int    edad_me { get; set; }
        public string telefono_me { get; set; }
        public string ciudad_me { get; set; }
        public string direccion_mee { get; set; }
        public byte[] foto_me { get; set; }
        public string passwod_me { get; set; }
        public int    idEpecialidad { get; set; }
        public int    idHorario { get; set; }
    }
}