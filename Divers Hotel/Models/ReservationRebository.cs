using Divers_Hotel.Data;
using Domain.Models;
using Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Models
{
    public class ReservationRebository:IReservation<Reservation>
    {
        private ApplicationDbContext _db { set; get; }

        public ReservationRebository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Reservation t)
        {
            //t.
        //    List<Room> GuestRooms = new List<Room>();
        //    foreach(int i in )

        //    Guest guest = new Guest()
        //    {
        //        Name = t.Name,
        //        Phone=t.Phone,
        //        AdultsNumber=t.AdultsNumber,
        //        ChildrenNumber=t.ChildrenNumber,
        //        Email=t.Email,
        //        SSN=t.SSN,
            
        //    };

        //    _db.Guests.Add(new Guest)
        }

        public void Remove(Reservation t)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
