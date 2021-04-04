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
              
                db.Add(reservation);
                TempData["Reservation"] = true;

            }
            else
            {
                TempData["Reservation"] = false;

            }
            return RedirectToAction("index"); 
        }
      
        // GET: DiversHotelController/Create
        [HttpPost]
        public ActionResult GetReservationTotal(TotalReservation t)
        {
     ViewBag.g=  db.GetReservationTotal(
                    t.Chechindate,
                      t.Chechoutdate,
                       t.NumberOfGuests,
                       t.RoomType,
                    t.MealPlane
                      );

            return View(t);
        }

       
    }
}
