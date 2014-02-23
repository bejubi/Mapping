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
            var modelAccounts = Domain.AccountManager.GetBankAccounts().Map();

            return View(modelAccounts);
        }

        //
        // GET: /Clean/Details/5
        public ActionResult Details(int id)
        {
            var modelAccount = Domain.AccountManager.GetBankAccount(id).Map();

            return View(modelAccount);
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
                var modelAccount = new Models.Account
                {
                    AcctNumber = Convert.ToInt32(collection["AcctNumber"]),
                    AcctType = collection["AcctType"],
                    AcctBalance = Convert.ToDecimal(collection["AcctBalance"]),
                    AcctHolder = new Models.Person
                    {
                        FName = "New",
                        LName = "Person",
                        Address1 = "111 Main St",
                        Address2 = "Apt 42",
                        City = "Any City",
                        State = "WI",
                        Zip = "12345",
                        Country = "USA",
                    }
                };

                Domain.AccountManager.AddBankAccount(modelAccount.Map());

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
            var modelAccount = Domain.AccountManager.GetBankAccount(id).Map();

            return View(modelAccount);
        }

        //
        // POST: /Clean/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var modelAccount = Domain.AccountManager.GetBankAccount(id).Map();

                modelAccount.AcctBalance = Convert.ToDecimal(collection["AcctBalance"]);
                modelAccount.AcctType = collection["AcctType"];

                var domainAccount = modelAccount.Map();

                Domain.AccountManager.UpdateBankAccount(domainAccount);

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
            var modelAccount = Domain.AccountManager.GetBankAccount(id).Map();

            return View(modelAccount);
        }

        //
        // POST: /Clean/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Domain.AccountManager.DeleteBankAccount(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
