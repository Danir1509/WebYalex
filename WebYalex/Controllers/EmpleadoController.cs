using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebYalex.Models;

namespace WebYalex.Controllers
{
    [Autenticado]
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vehiculo()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.vehiculo.ToList());
            }
        }

        public ActionResult ContratoEmpleado()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.contratos.ToList());
            }
        }

        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                List<clientes> listaClientes = context.clientes.ToList();
                ViewBag.ListaClientes = new SelectList(listaClientes, "id_cliente", "nombres");



                List<alquileres> listaAlquileres = context.alquileres.ToList();
                ViewBag.listaAlquileres = listaAlquileres;


                List<vehiculo> listaVehiculos = context.vehiculo.ToList();
                ViewBag.listaVehiculos = new SelectList(listaVehiculos, "id_vehiculo", "placa");


                /*
                 * para traer solo el id
                 * List<clientes> listaClientes = context.clientes.ToList();
                ViewBag.ListaClientes = listaClientes;*/
                /*
                 * para traer solo los existentes dentro del contrato
                 List<clientes> listaClientes = context.clientes.Where(c => c.contratos.Any()).ToList();
                ViewBag.ListaClientes = listaClientes;
                 */
            }

            return View();
        }

    }
}