using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.ViewModel
{
    public class ListaCitas
    {
        public int idCita { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public string cedula_pte { get; set; }
        public string cedula_med { get; set; }

        public string nombre_med { get; set; }
    }
}