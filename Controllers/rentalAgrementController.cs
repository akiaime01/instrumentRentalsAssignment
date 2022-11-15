using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using instrumentRentals.Models;

namespace instrumentRentals.Controllers
{
    public class rentalAgreementController : Controller
    {
        // GET: rentalAgreement
        public ActionResult Index()
        {
            instrument piano = new instrument();
            piano.name = "Piano";
            piano.type = "Percussion";
            customer customer2 = new customer();
            customer2.firstName = "Aaron";
            customer2.lastName = "Judge";
            rentalAgreement rentalAgreement1 = new rentalAgreement();
            rentalAgreement1.customer = customer2;
            rentalAgreement1.instrument = piano;
            rentalAgreement1.rentalStart = new DateTime(1995, 5, 14);
            

            return View(rentalAgreement1);
        }

        // GET: rentalAgreement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: rentalAgreement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: rentalAgreement/Create
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

        // GET:rentalAgreement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: rentalAgreement/Edit/5
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

        // GET: rentalAgreement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST:rentalAgreement/Delete/5
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