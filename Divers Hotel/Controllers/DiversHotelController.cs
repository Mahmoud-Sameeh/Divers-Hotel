using Domain.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Controllers
{
    public class DiversHotelController : Controller
    {
        // GET: DiversHotelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DiversHotelController/Reservation
        public ActionResult Reservation()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Reservation(Reservation reservation)
        {
            return View();
        }

        // GET: DiversHotelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiversHotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiversHotelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiversHotelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiversHotelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiversHotelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
