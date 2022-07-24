using ProyectoU2.Models;
using ProyectoU2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoU2.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {

            List<ListaPaciente> listaPaciente;
            using (ClinicaEntities db = new ClinicaEntities())
            {
                listaPaciente = (from d in db.paciente
                                 select new ListaPaciente
                                 {
                                     cedula_pte = d.cedula_pte,
                                     nombre_pte = d.nombre_pte,
                                     apellido_paterno_pte = d.apellido_paterno_pte,
                                     apellido_materno_pte = d.apellido_materno_pte,
                                     correo_pte = d.correo_pte,
                                     edad_pte = (int)d.edad_pte,
                                     ftelefono_pte = d.telefono_pte,
                                     ciudad_pte = d.ciudad_pte,
                                     foto_pte = d.foto_pte,

                                 }).ToList();
            }
            return View(listaPaciente);
        }
    }
}