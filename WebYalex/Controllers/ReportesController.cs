using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebYalex.Models;

namespace WebYalex.Controllers
{
    [Autenticado]
    public class ReportesController : Controller
    {

        public ActionResult PrintContrato()
        {
            using (DbModels context = new DbModels())
            {


                var contratos = context.contratos.ToList();

                //para mostrar fecha
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                //para mostrar cantidad
                int cantidadContratos = contratos.Count;
                ViewData["CantidadContratos"] = cantidadContratos;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintContrato", contratos).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");
            }
        }

        public ActionResult PrintVehiculo()
        {
            using (DbModels context = new DbModels())
            {

                var vehiculos = context.vehiculo.ToList();
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                int cantidadVehiculos = vehiculos.Count;
                ViewData["CantidadVehiculos"] = cantidadVehiculos;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintVehiculo", vehiculos).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");

            }
        }



        public ActionResult PrintEmpleado()
        {
            using (DbModels context = new DbModels())
            {

                var empleado = context.empleado.ToList();
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                int cantidadEmpleado = empleado.Count;
                ViewData["CantidadEmpleado"] = cantidadEmpleado;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintEmpleado", empleado).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");

            }
        }


        public ActionResult PrintCliente()
        {
            using (DbModels context = new DbModels())
            {

                var cliente = context.clientes.ToList();
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                int cantidadCliente = cliente.Count;
                ViewData["CantidadCliente"] = cantidadCliente;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintCliente", cliente).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");

            }
        }

        public ActionResult PrintAlquiler()
        {
            using (DbModels context = new DbModels())
            {


                var alquiler = context.alquileres.ToList();

                //para mostrar fecha
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                //para mostrar cantidad
                int cantidadAlquileres = alquiler.Count;
                ViewData["CantidadAlquileres"] = cantidadAlquileres;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintAlquiler", alquiler).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");
            }
        }

        public ActionResult PrintReserva()
        {
            using (DbModels context = new DbModels())
            {


                var reserva = context.reserva.ToList();

                //para mostrar fecha
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                //para mostrar cantidad
                int cantidadReservas = reserva.Count;
                ViewData["CantidadReservas"] = cantidadReservas;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintReserva", reserva).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");
            }
        }

        public ActionResult PrintEntrega()
        {
            using (DbModels context = new DbModels())
            {


                var entrega = context.entrega.ToList();

                //para mostrar fecha
                DateTime fechaActual = DateTime.Now;
                ViewData["FechaActual"] = fechaActual;

                //para mostrar cantidad
                int cantidadEntregas = entrega.Count;
                ViewData["CantidadEntregas"] = cantidadEntregas;

                var pdfBytes = new Rotativa.ViewAsPdf("PrintEntrega", entrega).BuildPdf(this.ControllerContext);
                var memoryStream = new MemoryStream(pdfBytes);
                return new FileStreamResult(memoryStream, "application/pdf");
            }
        }




    }
}