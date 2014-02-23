using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ClunkyController : Controller
    {
        //
        // GET: /Clunky/
        public ActionResult Index()
        {
            var serviceAccounts = Domain.AccountManager.GetBankAccounts();

            var clientAccounts = new List<Models.Account>();

            foreach (var serviceAccount in serviceAccounts)
            {
                var clientAccount = new Models.Account
                {
                    AcctNumber = serviceAccount.AccountNumber,
                    AcctType = serviceAccount.BankAccountType.ToString(),

                    AcctHolder = new Models.Person
                    {
                        FName = serviceAccount.PrimaryAccountholder.FirstName,
                        LName = serviceAccount.PrimaryAccountholder.LastName,

                        Address1 = serviceAccount.PrimaryAccountholder.ResidenceAddress.AddressLine1,
                        Address2 = serviceAccount.PrimaryAccountholder.ResidenceAddress.AddressLine2,
                        City = serviceAccount.PrimaryAccountholder.ResidenceAddress.City,
                        State = serviceAccount.PrimaryAccountholder.ResidenceAddress.State,
                        Zip = serviceAccount.PrimaryAccountholder.ResidenceAddress.PostalCode,
                        Country = "US", // default logic: leave out of mapper
                    },

                    AcctBalance = serviceAccount.Balance,
                };

                clientAccounts.Add(clientAccount);
            }

            return View(clientAccounts);
        }

        //
        // GET: /Clunky/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Clunky/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Clunky/Create
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
        // GET: /Clunky/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Clunky/Edit/5
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
        // GET: /Clunky/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Clunky/Delete/5
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
