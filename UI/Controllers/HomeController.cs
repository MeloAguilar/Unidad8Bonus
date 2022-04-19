using DAL.Listas;
using Entities;
using UI.ViewModels;
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
        private PlantasDescripcionesVM viewModel = new PlantasDescripcionesVM();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }



        /// <summary>
        /// Aqui solo recogemos el listado de 
        /// plantas para mostrarlo en la vista
        /// </summary>
        /// <returns>View: Index </returns>
        public IActionResult Index()
        {

            return View(viewModel);
        }



        /// <summary>
        /// Aqui recogemos la lista de plantas 
        /// junto con la descripcion de la planta elegida
        /// </summary>
        /// <param name="Planta"></param>
        /// <returns> View: Index</returns>
        /// 

        //TODO Hacer que el post reciba un model binding
        [HttpPost]
        public IActionResult Index(PlantasDescripcionesVM vm)
        {

            return View(vm);
        }















        //Vienen por defecto
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