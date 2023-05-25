using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebYalex.Models;

namespace WebYalex.Controllers
{
    public class EmpleadoAlquilerController : Controller
    {
        // GET: EmpleadoAlquiler
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.alquileres.ToList());
            }
        }

        // GET: EmpleadoAlquiler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpleadoAlquiler/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                List<clientes> listaClientes = context.clientes.ToList();
                ViewBag.listaClientes = new SelectList(listaClientes, "id_cliente", "nombres");


                List<vehiculo> listaVehiculos = context.vehiculo.ToList();
                ViewBag.listaVehiculos = new SelectList(listaVehiculos, "id_vehiculo", "placa");

            }


            return View();
        }

        // POST: EmpleadoAlquiler/Create
        [HttpPost]
        public ActionResult Create(alquileres alquileres)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels context = new DbModels())
                {
                    context.alquileres.Add(alquileres);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoAlquiler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoAlquiler/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoAlquiler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoAlquiler/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
