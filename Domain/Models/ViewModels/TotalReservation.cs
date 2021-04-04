using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.ViewModels
{
  public  class TotalReservation
    {
        public int Id { get; set; }
        public DateTime Chechindate { get; set; }
        public DateTime Chechoutdate { get; set; }
        public int NumberOfGuests { get; set; }
        public int RoomType { get; set; }
        public int MealPlane { get; set; }
    }
}
