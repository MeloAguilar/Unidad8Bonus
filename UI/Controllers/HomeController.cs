using DAL.Listas;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ListadosPlantas plantas = new ListadosPlantas();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
  
           
            ViewBag.Plantas = (IEnumerable<clsPlanta>)plantas.ListadoCompleto();

            return View();
        }

        [HttpPost]
        public IActionResult Index(string Plantas)
        {
            
            ViewBag.Plantas = (IEnumerable<clsPlanta>)plantas.ListadoCompleto();
            string desc = "";
            for(int i = 0; i < plantas.ListadoCompleto().Count && desc.Equals(""); i++)
    {
                if (plantas.ListadoCompleto()[i].Nombre.Equals(Plantas))
                {
                    desc = plantas.ListadoCompleto()[i].Datos;
                }

                ViewBag.Desc = desc;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}