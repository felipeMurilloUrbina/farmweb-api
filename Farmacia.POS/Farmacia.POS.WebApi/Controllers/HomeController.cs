using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farmacia.POS.WebApi.Controllers
{
    public class Propiedad
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            Dictionary<string, string> propiedades = new Dictionary<string, string>();
            //propiedades.FirstOrDefault(d=>d.Key=="").Value
            propiedades.FirstOrDefault(d => d.Key == "Encabezado");
            //propiedades.Where(p=>p.Key.Contains("")).Count()>0
            return View();
        }

        private List<Propiedad> getPropiedades(string cadena)
        {
            var split = cadena.Split('@');
            List<Propiedad> propiedades = new List<Propiedad>();
            foreach (var cadenaSplit in split)
            {
                var splitDosPuntos = cadenaSplit.Split(':');
                propiedades.Add(new Propiedad() { Clave = splitDosPuntos[0], Descripcion = splitDosPuntos.Length > 1 ? splitDosPuntos[1] : "" });
            }
            return propiedades;
        }
        private string getRequerido(List<Propiedad> propiedades)
        {
            var propiedad = propiedades.FirstOrDefault(p => p.Clave.Equals("Capturable"));
            return propiedad == null ? propiedad.Descripcion : "";
        }
    }
}
