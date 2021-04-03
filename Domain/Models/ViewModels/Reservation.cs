using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models.ViewModels
{
   public class Reservation
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        

        public string Email { get; set; }
       
        public string Phone { get; set; }
        [DisplayName("Room Type")]    
        public int RoomTypeNum { get; set; }
         [DisplayName("Meal Plan")]    
        public int MealPlan { get; set; }

        public int AdultsNumber { get; set; }
        
        public int ChildrenNumber { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public int RoomsCount { get; set; }
    }
}
