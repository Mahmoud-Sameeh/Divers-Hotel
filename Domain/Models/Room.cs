using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
  public  class Room
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsEmpty { get; set; }
        public int GuestID { set; get; }
        public int RoomTypeID { set; get; }
        public int MealPlanID { set; get; }
        public Guest Guest { get; set; }
        public RoomType RoomType { set; get; }
        public MealPlan MealPlan { get; set; }
    }
}
