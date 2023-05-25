using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebYalex.Models;

namespace WebYalex.Controllers
{
    public class EmpleadoReservaController : Controller
    {
        // GET: EmpleadoReserva
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.reserva.ToList());
            }
        }

        // GET: EmpleadoReserva/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpleadoReserva/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                List<clientes> listaClientes = context.clientes.ToList();
                ViewBag.ListaClientes = new SelectList(listaClientes, "id_cliente", "nombres");

                List<vehiculo> listaVehiculos = context.vehiculo.ToList();
                ViewBag.listaVehiculos = new SelectList(listaVehiculos, "id_vehiculo", "placa");

                List<empleado> listaEmpleados = context.empleado.ToList();
                ViewBag.listaEmpleados = new SelectList(listaEmpleados, "id_empleado", "nombre");

            }

            return View();
        }

        // POST: EmpleadoReserva/Create
        [HttpPost]
        public ActionResult Create(reserva reserva)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels context = new DbModels())
                {
                    context.reserva.Add(reserva);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoReserva/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoReserva/Edit/5
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

        // GET: EmpleadoReserva/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoReserva/Delete/5
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
