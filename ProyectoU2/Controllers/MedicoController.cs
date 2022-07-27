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
                                  HoraCita = (TimeSpan)c.hora,
                                  FechaCita = (DateTime)c.fecha
                              }).ToList();
            }
            return View(listaCitas);
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(MedicoViewModel medicoViewModel)
        {
            try
            {
                //Validar el modelo
                if (ModelState.IsValid)
                {
                    HttpPostedFileBase fileBase = Request.Files[0];
                    WebImage image = new WebImage(fileBase.InputStream);
                    medicoViewModel.foto_me = image.GetBytes();
                    //Coexión a la base de datos
                    using (ClinicaEntities db = new ClinicaEntities())
                    {
                        var oMedico = new medico();
                        oMedico.nombre_me = medicoViewModel.nombre_me;
                        oMedico.cedula_me = medicoViewModel.cedula_me;
                        oMedico.apellido_paterno_me = medicoViewModel.apellido_paterno_me;
                        oMedico.apellido_materno_me = medicoViewModel.apellido_materno_me;
                        oMedico.correo_me = medicoViewModel.correo_me;
                        oMedico.fNacimiento_me = medicoViewModel.fNacimiento_me;
                        oMedico.edad_me = medicoViewModel.edad_me;
                        oMedico.telefono_me = medicoViewModel.telefono_me;
                        oMedico.ciudad_me = medicoViewModel.ciudad_me;
                        oMedico.direccion_me = medicoViewModel.direccion_me;
                        oMedico.foto_me = medicoViewModel.foto_me;
                        oMedico.passwod_me = medicoViewModel.passwod_me;
                        oMedico.idEpecialidad = medicoViewModel.idEspecialidad;
                        oMedico.idHorario = medicoViewModel.idHorario;
                        //Almacenar en la base de datos
                        db.medico.Add(oMedico);
                        db.SaveChanges();
                    }
                    return Redirect("~/Medico");
                }
                return View(medicoViewModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Eliminar(string cedula_me)
        {
            using (ClinicaEntities db = new ClinicaEntities())
            {
                var oMedico = db.medico.Find(cedula_me);
                db.medico.Remove(oMedico);
                db.SaveChanges();
            }
            return Redirect("~/Medico");
        }
        /*
        public ActionResult getImage(string cedula_me)
        {
            ClinicaEntities db = new ClinicaEntities();

            medico model = db.medico.Find(cedula_me);

            byte[] byteImage = model.foto_me;

            MemoryStream memoryStream = new MemoryStream(byteImage);

            Image image = Image.FromStream(memoryStream);

            memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            memoryStream.Position = 0;

            return File(memoryStream, "image/jpg");
        }
        */
        
    }
}