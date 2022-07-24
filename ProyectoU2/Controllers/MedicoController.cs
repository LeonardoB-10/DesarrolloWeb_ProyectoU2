using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoU2.Models;
using ProyectoU2.Models.ViewModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Helpers;
using ProyectoU2.Models.TableViewModel;


namespace ProyectoU2.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            List<ListaMedico> listaMedico;
            using (ClinicaEntities db = new ClinicaEntities())
            {
                listaMedico = (from d in db.medico
                                 select new ListaMedico
                                 {
                                     cedula_me = d.cedula_me,
                                     nombre_me = d.nombre_me,
                                     apellido_paterno_me = d.apellido_paterno_me,
                                     apellido_materno_me = d.apellido_materno_me,
                                     correo_me = d.correo_me,
                                     edad_me = (int)d.edad_me,
                                     telefono_me = d.telefono_me,
                                     ciudad_me = d.ciudad_me,
                                     foto_me = d.foto_me,

                                 }).ToList();
            }
            return View(listaMedico);
        }

        public ActionResult Editar(string cedula_me)
        {
            MedicoViewModel model = new MedicoViewModel();
            using (ClinicaEntities db = new ClinicaEntities())
            {
                var oMedico = db.medico.Find(cedula_me);
                model.correo_me = oMedico.correo_me;
                model.telefono_me = oMedico.telefono_me;
                model.ciudad_me = oMedico.ciudad_me;
                model.direccion_me = oMedico.direccion_me;
                model.passwod_me = oMedico.passwod_me;
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Editar(MedicoViewModel medicoModel)
        {
            try
            {
                //Validar el formulario
                if (ModelState.IsValid)
                {
                    using (ClinicaEntities db = new ClinicaEntities())
                    {
                        var oMedico = db.medico.Find(medicoModel.cedula_me);
                        oMedico.correo_me = medicoModel.correo_me;
                        oMedico.telefono_me = medicoModel.telefono_me;
                        oMedico.ciudad_me = medicoModel.ciudad_me;
                        oMedico.direccion_me = medicoModel.direccion_me;
                        oMedico.passwod_me = medicoModel.passwod_me;

                        db.Entry(oMedico).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/Medico/");
                }
                return View(medicoModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Citas(string cedula_me)
        {
            List<CitasTableViewModel> listaCitas = null;
            using (ClinicaEntities db = new ClinicaEntities())
            {
                listaCitas = (from c in db.cita
                              join p in db.paciente on c.cedula_pte equals p.cedula_pte
                              join m in db.medico on c.cedula_me equals m.cedula_me
                              where c.cedula_me == cedula_me
                              select new CitasTableViewModel
                              {
                                  Nombre = p.nombre_pte,
                                  Cedula = p.cedula_pte,
                                  Edad = (int)p.edad_pte,
                                  Correo = p.correo_pte,
                                  Telefono = p.telefono_pte,
                              }).ToList();
            }
            return View(listaCitas);
        }
    }
}