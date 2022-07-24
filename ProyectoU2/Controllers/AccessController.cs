using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoU2.Models;

namespace ProyectoU2.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(String user, String password)
        {
            try
            {

                using (ClinicaEntities db = new ClinicaEntities())//creamos la conexion a la base de datos 
                {
                    //Con la conexion se realiza la consulta
                    var lst = from d in db.pacientes
                              where d.usuario_pte == user && d.passwod_pte == password
                              select d;//seleccionamos todo el objeto con sus caracteristicas

                    if (lst.Count() > 0)//Si por lo menos hay una dato en la consulta
                    {
                        paciente oPaciente = lst.First();//Se crea una sesionn 
                        Session["User"] = oPaciente;//recibe el objeto de tipo usuario y se especifica el nombre
                        return Content("1");
                    }

                    else
                    {
                        return Content("Usuario invalido:(");//En caso que los datos esten mal ingresados 
                    }

                }

            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :(" + ex.Message);

            }
        }
    }
}