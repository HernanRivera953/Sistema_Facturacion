using Facturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facturacion.Controllers
{
    public class ClientesTController : Controller
    {
        // GET: ClientesT
        public ActionResult Index()
        {
            BDFacturacion db = new BDFacturacion();

            var clientes = db.TBLCLIENTES;
            return View(clientes.ToList());
        }

        public ActionResult Nuevo()
        {
            BDFacturacion db = new BDFacturacion();
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BDFacturacion db = new BDFacturacion();
                    var NuevosDatos = new TBLCLIENTES();
                    NuevosDatos.StrNombre = collection["strNombre"];
                    NuevosDatos.NumDocumento = long.Parse(collection["NumDocumento"]);
                    NuevosDatos.StrDireccion = collection["StrDireccion"];
                    NuevosDatos.StrTelefono = collection["StrTelefono"];
                    NuevosDatos.StrEmail = collection["StrEmail"];
                    NuevosDatos.DtmFechaModifica = DateTime.Now.Date;
                    NuevosDatos.StrUsuarioModifica = "Valen y Hernan";

                    db.TBLCLIENTES.Add(NuevosDatos);
                    db.SaveChanges();

                    return Redirect("/ClientesT/Index");
                }
                return View(collection);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Editar(int id)
        {
            BDFacturacion db = new BDFacturacion();
            var DatosEmple = db.TBLCLIENTES.Find(id);

            return View(DatosEmple);
        }

        [HttpPost]
        public ActionResult Editar(TBLCLIENTES model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (BDFacturacion db = new BDFacturacion())
                    {
                        var DatosModifi = db.TBLCLIENTES.Find(model.IdCliente);

                        DatosModifi.StrNombre = model.StrNombre;
                        DatosModifi.NumDocumento = model.NumDocumento;
                        DatosModifi.StrDireccion = model.StrDireccion;
                        DatosModifi.StrTelefono = model.StrTelefono;
                        DatosModifi.StrEmail = model.StrEmail;
                        DatosModifi.DtmFechaModifica = DateTime.Now.Date;
                        DatosModifi.StrUsuarioModifica = "Valen y Hernan";

                        db.Entry(DatosModifi).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("/ClientesT/index");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Borrar(int id)
        {
            try
            {
                using (BDFacturacion db = new BDFacturacion())
                {
                    var otabla = db.TBLCLIENTES.Find(id);
                    db.TBLCLIENTES.Remove(otabla);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Redirect("/ClientesT/index");
        }
    }
}