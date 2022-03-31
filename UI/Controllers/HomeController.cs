﻿using DAL.Listas;
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
        List<SelectListItem> items = new List<SelectListItem>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
            int cont = 0;
            foreach (var item in plantas.plantas)
            {

                items.Add(new SelectListItem { Text = item.Nombre, Value = cont.ToString() });
                cont++;

            }
        }

        public IActionResult Index()
        {
  
            IEnumerable<SelectListItem> lista = items;
            ViewBag.Plantas = (IEnumerable<clsPlanta>)plantas.plantas;

            return View();
        }

        [HttpPost]
        public IActionResult Index(string Plantas)
        {
            ViewBag.Plantas = (IEnumerable<clsPlanta>)plantas.plantas;
            string desc = "";
            for(int i = 0; i < plantas.plantas.Count && desc.Equals(""); i++)
    {
                if (plantas.plantas[i].Nombre.Equals(Plantas))
                {
                    desc = plantas.plantas[i].Datos;
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