using ProyectoU2.Models;
using ProyectoU2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoU2.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {

            List<ListaAdministrador> listaDireccion;
            using (ClinicaEntities db = new ClinicaEntities())
            {
                listaDireccion = (from d in db.direccions
                                 select new ListaAdministrador
                                 {
                                     cedula_di = d.cedula_di,
                                     nombre_di = d.nombre_di,
                                     apellido_paterno_di = d.apellido_paterno_di,
                                     apellido_materno_di = d.apellido_materno_di,
                                     correo_di = d.correo_di,
                                     roles = d.roles,
                                     telefono_di = d.telefono,
                                     ciudad_di = d.ciudad_di,
                                     foto_di = d.foto_di,
                                     usuario_di = d.usuario_di,

                                 }).ToList();
             
            }
            return View(listaDireccion);
        }
        public ActionResult Registrar(CitasViewModel modelC)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ClinicaEntities db = new ClinicaEntities())
                    {
                        var d = new cita();
                        var p = new paciente();
                        var m = new medico();
                        d.fecha = modelC.fecha;
                        d.hora = modelC.hora;
                        p.cedula_pte = modelC.cedula_pte;
                        m.cedula_me = modelC.cedula_med;
                        db.citas.Add(d);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return View();
        }

        
        public ActionResult Editar(int id)
        {
            CitasViewModel citaM = new CitasViewModel();
            using (ClinicaEntities db = new ClinicaEntities())
            {
                var oD = db.citas.Find(id);
                citaM.fecha = (DateTime)oD.fecha;
                citaM.hora = (TimeSpan)oD.hora;
   
            }
            return View(citaM);
        }
    }
}