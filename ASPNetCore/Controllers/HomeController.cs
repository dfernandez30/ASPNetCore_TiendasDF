using ASPNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCore.Services;
using TiendasDF.Models;


namespace ASPNetCore.Controllers
{
    
    public class HomeController : Controller
    {
        public IERepositorioMensaje Repositorio { get; }
        public IERepositorioPanes Panes { get; }
        public IERepositorioQueso Quesos { get; }
        public IERepositorioCarne Carnes { get; }
        public IERepositorioJefe Jefes { get; }
        public IERepositorioGuardia Guardias { get; }
        public IERepositorioCajero Cajeros { get; } 
    public HomeController(IERepositorioMensaje repositorio, IERepositorioPanes repanes,
            IERepositorioQueso requesos,IERepositorioCarne recarnes,IERepositorioJefe rejefes,
            IERepositorioGuardia reguardias, IERepositorioCajero recajeros)
        {
            Repositorio = repositorio;
            Panes = repanes;
            Quesos = requesos;
            Carnes = recarnes;
            Jefes = rejefes;
            Guardias = reguardias;
            Cajeros = recajeros;
        }     
        public IActionResult Index()
        {
            var mensajes = Repositorio.ObtenerTodo();
            return View(mensajes);
        }      
        public IActionResult Pan()
        {
            var mensajes = Panes.ObtenerPanes();
            return View(mensajes);
        }
        public IActionResult Queso()
        {
            var mensajes = Quesos.ObtenerQuesos();
            return View(mensajes);
        }
        public IActionResult Carne()
        {
            var mensajes = Carnes.ObtenerCarnes();
            return View(mensajes);
        }
        public IActionResult Personal()
        {
            ViewModel model = new ViewModel();
            model.Jefe = Jefes.ObtenerJefes();
            model.Guardia = Guardias.ObtenerGuardias();
            model.Cajero = Cajeros.ObtenerCajeros();
            return View(model);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var mensajes = Repositorio.ObtenerTodo();
            return View(mensajes);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
