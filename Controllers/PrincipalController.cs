using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facturacion.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal-- va a mostrar la informacion de la  pagina inicial
        public ActionResult Index()
        {
            return View();
        }

        //va a mostrar la informacion de la pagina Acerca de
        public ActionResult Acerca()
        {
            return View();
        }

        //va a mostrar la informacion de la pagina contactos
        public ActionResult Contacto()
        {
            return View();
        }

        //va a mostrar la informacion de la pagina Ayudas
        public ActionResult Ayuda()
        {
            return View();
        }


    }
}