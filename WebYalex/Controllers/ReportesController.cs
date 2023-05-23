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
    }
}