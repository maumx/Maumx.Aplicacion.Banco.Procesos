using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Maumx.Aplicacion.Banco.Entidades;

namespace Maumx.Aplicacion.Web.Controllers
{
    public class ClienteController : Controller
    {
        public ClienteController()
        {
            clientes = new List<Cliente>();
            
            if (System.Web.HttpContext.Current.Session["ListaClientes"]==null)
            {
                System.Web.HttpContext.Current.Session.Add("ListaClientes", clientes);
            }
            
        }

        List<Cliente> clientes { get; set; }

        // GET: Cliente
        public ActionResult Index()
        {
            clientes = (List<Cliente>)System.Web.HttpContext.Current.Session["ListaClientes"];

            for (int i = 0; i < 10; i++)
            {
                clientes.Add(new Cliente() { Id = i, Nombre = string.Format("Prueba{0}", i), CuentasBancarias = new List<CuentaBancaria>() });
            }


            return View(clientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            clientes = (List<Cliente>)System.Web.HttpContext.Current.Session["ListaClientes"];

            Cliente encontrado = clientes[id];

            return View(encontrado);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
