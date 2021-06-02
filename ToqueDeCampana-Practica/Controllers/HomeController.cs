using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToqueDeCampana_Practica.Models;

using System.Text.Json;
using System.Text.Json.Serialization;


namespace ToqueDeCampana.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly bd_toque_campanaV1Context _context;
        public object SerializerSettings { get; set; }
        public HomeController(ILogger<HomeController> logger , bd_toque_campanaV1Context context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Login(String email, String clave){

            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(clave)){

              var user=  _context.TblAlumnos.FirstOrDefault(e => e.VchCorreo == email && e.VchMatricula == clave);
                

                if (user!=null)
                {

                    return RedirectToAction("Alumno", "Home", new { matricula = user.VchMatricula });

                   // return (ActionResult)Login(newuser.VchNombre);
                }
                else
                {
                    return (ActionResult)Login("Lo sentimos!!, No estas Registrado en el sistema");
                }

            }
            else{

                return (ActionResult)Login("Campos vacios, Por favor llene los Campos");

            }
        }

      

        public IActionResult Login(String menssaje = "")
        {
            ViewBag.Menssaje = menssaje;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Alumno(String matricula)
        {


            ToqueDeCampana_Practica.Models.TblAlumno tblAlumno = new ToqueDeCampana_Practica.Models.TblAlumno();
            var usuario =_context.TblAlumnos.FirstOrDefault(e => e.VchMatricula == matricula);

            tblAlumno.IdAlumnos = usuario.IdAlumnos;
            tblAlumno.VchNombre = usuario.VchNombre; 
            tblAlumno.VchApellidos = usuario.VchApellidos;
            tblAlumno.VchCorreo = usuario.VchCorreo;
            tblAlumno.VchMatricula =matricula;
            tblAlumno.VchTel1 = usuario.VchTel1;
            tblAlumno.VchTel2 = usuario.VchTel2;
          


            ViewData["alumno"] = tblAlumno;
            ViewData["titulo"] = "Datos del alumno";
            ObtieneCarrera();
            ObtieneResidencia();

            return View(tblAlumno);
        }


        public IActionResult ObtieneCarrera()
        {
            var carrera = _context.TblUniversidads.ToList();

            List<SelectListItem> items = carrera.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.VchUniversidad.ToString(),
                    Value = d.IdUniversidad.ToString(),
                    Selected = false
                };
            });

            ViewBag.Item = items;
            return View(); 
        }

        public JsonResult GetCarreraId(int Id)
        {
            var Carrera = _context.TblCarreras.Where(x => x.IdUniversidad1==Id).ToList();
            Console.WriteLine(Carrera);


            var json = JsonSerializer.Serialize(Carrera);

            Console.WriteLine(json);
            
            return Json(json);

        }
        public IActionResult ObtieneResidencia()
        {
            var residencias = _context.TblResidencia.ToList();

            List<SelectListItem> ciudad = residencias.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.VchCiudad.ToString(),
                    Value = d.IdResidencia.ToString(),
                    Selected = false
                };
            });

            ViewBag.Ciudad = ciudad;
            return View();
        }
        public JsonResult GetResidencia(int Id)
        {
            var Residencia = _context.TblResidencia.Where(x => x.IdResidencia == Id).ToList();
            Console.WriteLine(Residencia);


            var json = JsonSerializer.Serialize(Residencia);

            Console.WriteLine(json);

            return Json(json);

        }
        [HttpPost]
        public IActionResult Post(TblAlumno alumno)
        {
                _context.TblAlumnos.Update(alumno);
                _context.SaveChanges();

                 return RedirectToAction("Login", "Home");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
