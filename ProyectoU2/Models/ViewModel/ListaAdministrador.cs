using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class ListaAdministrador
    {
        public int idDireccion { get; set; }
        public string cedula_di { get; set; }
        public string nombre_di { get; set; }
        public string apellido_paterno_di { get; set; }
        public string apellido_materno_di { get; set; }
        public string correo_di { get; set; }
        public string roles { get; set; }
        public string telefono_di { get; set; }
        public string ciudad_di { get; set; }
        public string direccion_di { get; set; }
        public byte[] foto_di { get; set; }
        public string usuario_di { get; set; }
        public string passwod_di { get; set; }
    }
}