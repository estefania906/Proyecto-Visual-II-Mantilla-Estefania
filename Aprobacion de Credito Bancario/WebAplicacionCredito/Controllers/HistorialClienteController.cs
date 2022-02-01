using Microsoft.AspNetCore.Mvc;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAplicacionCredito.Controllers
{
    public class HistorialClienteController : Controller
    {
        private readonly ModeloDB.ModeloDB db;
        public HistorialClienteController(ModeloDB.ModeloDB db)
        {

            this.db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Historial_Cliente> listaHistorialCliente = db.historial_cliente;
            return View(listaHistorialCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
