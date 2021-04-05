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
                return RedirectToAction("GetReservationTotal",reservation);
            }
            else
            {
                TempData["Reservation"] = false;

            }
            return RedirectToAction("index"); 
        }

        // GET: DiversHotelController/Create
        public ActionResult GetReservationTotal( )
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetReservationTotal(Reservation reservation)
        {
            ViewBag.g = db.GetReservationTotal(reservation.From, reservation.To, reservation.AdultsNumber + reservation.ChildrenNumber, reservation.RoomTypeNum, reservation.MealPlan);

            return View(reservation);
        }

       
    }
}
