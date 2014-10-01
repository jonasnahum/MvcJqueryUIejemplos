using MvcJqueryUIejemplos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJqueryUIejemplos.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Acordeon()
        {
            return View();        
        }

        public ActionResult Animation()
        {
            return View();
        }
        public ActionResult DatePicker()
        {
            Persona model = new Persona();
            return View(model);
        }
        [HttpPost]
        public ActionResult DatePicker(Persona model)
        {
            return View(model);
        }
        public ActionResult Autocomplete() 
        {
            return View();
        }
        public ActionResult ObtenerEstados() 
        {
            string[] estados = new string[] {            
                        "Aguascalientes",
                        "Baja California",
                        "Baja California Sur",
                        "Campeche",
                        "Chiapas",
                        "Chihuahua",
                        "Coahuila",
                        "Colima",
                        "Distrito Federal",
                        "Durango",
                        "Estado de México",
                        "Guanajuato",
                        "Guerrero",
                        "Hidalgo",
                        "Jalisco",
                        "Michoacán",
                        "Morelos",
                        "Nayarit",
                        "Nuevo León",
                        "Oaxaca",
                        "Puebla",
                        "Querétaro",
                        "Quintana Roo",
                        "San Luis Potosí",
                        "Sinaloa",
                        "Sonora",
                        "Tabasco",
                        "Tamaulipas",
                        "Tlaxcala",
                        "Veracruz",
                        "Yucatán",
                        "Zacatecas"
                            };
            return Json(estados, JsonRequestBehavior.AllowGet);
        }

    }
}
