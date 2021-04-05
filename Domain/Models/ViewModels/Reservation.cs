using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models.ViewModels
{
   public class Reservation
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string SSN { get; set; }
        [Required]


        public string Email { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]
        [DisplayName("Room Type")]
        public int RoomTypeNum { get; set; }
         [DisplayName("Meal Plan")]
        [Required]

        public int MealPlan { get; set; }
        [Required]

        public int AdultsNumber { get; set; }
        [Required]

        public int ChildrenNumber { get; set; }
        [Required]

        public DateTime From { get; set; }
        [Required]

        public DateTime To { get; set; }

        public int RoomsCount { get; set; }
    }
}
