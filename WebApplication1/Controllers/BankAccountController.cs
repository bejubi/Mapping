using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Mappers;

namespace WebApplication1.Controllers
{
    public class BankAccountController : Controller
    {
        //
        // GET: /Clean/
        public ActionResult Index()
        {
            var serviceAccounts = Domain.AccountManager.GetBankAccounts().Map();

            return View(serviceAccounts);
        }

        //
        // GET: /Clean/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Clean/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Clean/Create
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

        //
        // GET: /Clean/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Clean/Edit/5
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

        //
        // GET: /Clean/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Clean/Delete/5
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
