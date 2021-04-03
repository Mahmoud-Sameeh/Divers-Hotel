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

            List<Room> GuestRooms = new List<Room>();
            for (int i = 0; i < t.RoomsCount; i++)
            {
                GuestRooms.Add(new Room() { From=t.From,To=t.To,IsEmpty=false,MealPlanID=t.MealPlan,
                    RoomTypeID=_db.RoomTypes.FirstOrDefault(z=>z.Id==t.RoomTypeNum).Id});
            }

                Guest guest = new Guest()
                {
                    Name = t.Name,
                    Phone = t.Phone,
                    AdultsNumber = t.AdultsNumber,
                    ChildrenNumber = t.ChildrenNumber,
                    Email = t.Email,
                    SSN = t.SSN,
                    Rooms=GuestRooms,
                    

                };

            _db.Guests.Add(guest);
            _db.SaveChanges();
        }

        public List<MealPlan> GetAllMealTypeList()
        {
                  return  _db.MealPlans.ToList();
        }

        public List<RoomType> GetRoomTypeNumList()
        {
            return _db.RoomTypes.ToList();
        }

        public void Remove(Reservation t)
        {
          // _db.Remove(G)
        }

        public void Update(Reservation t)
        {
            throw new NotImplementedException();
        }

      
    }
}
