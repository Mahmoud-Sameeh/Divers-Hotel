using Divers_Hotel.Data;
using Divers_Hotel.Models;
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
        private IReservation<Reservation> db  { get;set; }

         public DiversHotelController(IReservation<Reservation> RRebository )
        {
            db = RRebository;
        }
        // GET: DiversHotelController
        public ActionResult Index()
        {

            return View();
        }

        // GET: DiversHotelController/Reservation
        public ActionResult Reservation()
        {
            ViewBag.mealplans = db.GetAllMealTypeList();
            ViewBag.RoomTypes = db.GetRoomTypeNumList();

            return View();
        } 
        [HttpPost]
        public ActionResult Reservation(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                ViewBag.mealplans = db.GetAllMealTypeList();
                ViewBag.RoomTypes = db.GetRoomTypeNumList();
               ViewBag.price= db.GetReservationTotal(
                    reservation.From,
                    reservation.To,
                    reservation.AdultsNumber + reservation.ChildrenNumber,
                    reservation.RoomTypeNum,
                    reservation.MealPlan
                    );
                db.Add(reservation);
                TempData["Reservation"] = true;

            }
            else
            {
                TempData["Reservation"] = false;

            }
            return RedirectToAction("index"); 
        }
        public ActionResult GetReservationTotal()
        {
           
            return View();
        }
        // GET: DiversHotelController/Create
        public ActionResult GetReservationTotal(DateTime CheckInDate, DateTime CheckOutDate, int NumberOfGuests, int RoomType, int MealPlane)
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
