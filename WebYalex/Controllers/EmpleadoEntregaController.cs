using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebYalex.Models;

namespace WebYalex.Controllers
{
    public class EmpleadoEntregaController : Controller
    {
        // GET: EmpleadoEntrega
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.entrega.ToList());
            }
        }

        // GET: EmpleadoEntrega/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpleadoEntrega/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                List<clientes> listaClientes = context.clientes.ToList();
                ViewBag.listaClientes = new SelectList(listaClientes, "id_cliente", "nombres");

                List<empleado> listaEmpleados = context.empleado.ToList();
                ViewBag.listaEmpleados = new SelectList(listaEmpleados, "id_empleado", "nombre");

                List<vehiculo> listaVehiculos = context.vehiculo.ToList();
                ViewBag.listaVehiculos = new SelectList(listaVehiculos, "id_vehiculo", "placa");

                List<contratos> listaContratos = context.contratos.ToList();
                ViewBag.listaContratos = new SelectList(listaContratos, "id_contrato", "id_contrato");


            }


            return View();
        }

        // POST: EmpleadoEntrega/Create
        [HttpPost]
        public ActionResult Create(entrega entrega)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels context = new DbModels())
                {
                    context.entrega.Add(entrega);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoEntrega/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoEntrega/Edit/5
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

        // GET: EmpleadoEntrega/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoEntrega/Delete/5
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
