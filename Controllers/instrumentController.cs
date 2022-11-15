using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using instrumentRentals.Models;

namespace instrumentRentals.Controllers
{
    public class customerController : Controller
    {
        // GET: customer
        public ActionResult Index()
        {
            customer customer1 = new customer();
            customer1.firstName = "Andrew";
            customer1.lastName = "Kotan";

            return View(customer1);
        }

        // GET: customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET:customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}