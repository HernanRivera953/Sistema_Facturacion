using Facturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facturacion.Controllers
{
    public class ProductosTController : Controller
    {
        // GET: ProductosT
        public ActionResult Index()
        {
            BDFacturacion db = new BDFacturacion();

            var empleados = db.TBLEMPLEADO;
            return View(empleados.ToList());
        }

        public ActionResult Nuevo()
        {
            BDFacturacion db = new BDFacturacion();
            ViewBag.IdCategoria = new SelectList(db.TBLCATEGORIA_PROD, "IdCategoria", "StrDescripcion");
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
                    var NuevosDatos = new TBLPRODUCTO();
                    NuevosDatos.StrNombre = collection["StrNombre"];
                    NuevosDatos.StrCodigo = collection["StrCodigo"];
                    NuevosDatos.NumPrecioCompra = Convert.ToDouble(collection["NumPrecioCompra"]);
                    NuevosDatos.NumPrecioVenta = Convert.ToDouble(collection["NumPrecioVenta"]);
                    NuevosDatos.IdCategoria = int.Parse(collection["IdCategoria"]);
                    NuevosDatos.StrDetalle = collection["StrDetalle"];
                    NuevosDatos.strFoto = collection["strFoto"];
                    NuevosDatos.NumStock = Convert.ToInt32(collection["NumStock"]);
                    NuevosDatos.DtmFechaModifica = DateTime.Now.Date;
                    NuevosDatos.StrUsuarioModifica = "Valen y Hernan";

                    db.TBLPRODUCTO.Add(NuevosDatos);
                    db.SaveChanges();

                    return Redirect("/ProductosT/Index");
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
            var DatosEmple = db.TBLPRODUCTO.Find(id);

            BDFacturacion db2 = new BDFacturacion();
            ViewBag.IdCategoria = new SelectList(db.TBLCATEGORIA_PROD, "IdCategoria", "StrDescripcion", DatosEmple.IdCategoria);


            return View(DatosEmple);
        }

        [HttpPost]
        public ActionResult Editar(TBLPRODUCTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (BDFacturacion db = new BDFacturacion())
                    {
                        var DatosModifi = db.TBLPRODUCTO.Find(model.IdProducto);

                        DatosModifi.StrNombre = model.StrNombre;
                        DatosModifi.StrCodigo = model.StrCodigo;
                        DatosModifi.NumPrecioCompra = model.NumPrecioCompra;
                        DatosModifi.NumPrecioVenta = model.NumPrecioVenta;
                        DatosModifi.IdCategoria = model.IdCategoria;
                        DatosModifi.StrDetalle = model.StrDetalle;
                        DatosModifi.strFoto = model.strFoto;
                        DatosModifi.NumStock = model.NumStock;
                        DatosModifi.DtmFechaModifica = DateTime.Now.Date;
                        DatosModifi.StrUsuarioModifica = "Valen y Hernan";

                        db.Entry(DatosModifi).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("/ProductosT/Index");
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
                    var otabla = db.TBLPRODUCTO.Find(id);
                    db.TBLPRODUCTO.Remove(otabla);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Redirect("/ProductosT/Index");
        }
    }
}