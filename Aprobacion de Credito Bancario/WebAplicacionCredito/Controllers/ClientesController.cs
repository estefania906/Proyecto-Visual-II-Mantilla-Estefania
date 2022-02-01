using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAplicacionCredito.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ModeloDB.ModeloDB db;
        public ClientesController(ModeloDB.ModeloDB db)
        {

            this.db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Cliente> listaCliente = db.cliente.Include(cliente=>cliente.Garante);
            return View(listaCliente);
        }
        //Crear una formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Grabar una materia
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            db.cliente.Add(cliente);
            db.SaveChanges();

            TempData["mensaje"] = $"El cliente {cliente.NombreCliente + " " + cliente.ApellidoCliente} ha sido creado exitosamente";

            return RedirectToAction("Index");
        }

        //Crear una formulario vacio
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Cliente cliente = db.cliente.Find(id);
            return View(cliente);
        }
        //Actualizar una materia
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            db.cliente.Update(cliente);
            db.SaveChanges();

            TempData["mensaje"] = $"El cliente {cliente.NombreCliente + " " + cliente.ApellidoCliente} ha sido actualizada exitosamente";


            return RedirectToAction("Index");
        }

        //Enviar a un formulario con los datos de la materia eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Cliente cliente = db.cliente.Find(id);
            return View(cliente);
        }
        //Actualizar una materia
        [HttpPost]
        public IActionResult Delete(Cliente cliente)
        {
            db.cliente.Remove(cliente);
            db.SaveChanges();

            TempData["mensaje"] = $"El cliente ha sido eliminado exitosamente";

            return RedirectToAction("Index");
        }

    }
}
