using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoU2.Models.TableViewModel
{
    public class CitasTableViewModel
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string HoraCita { get; set; }
        public string FechaCita { get; set; }
    }
}