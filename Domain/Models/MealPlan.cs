using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
   public class MealPlan
    {
        public int Id { get; set; }
        public string MealType { get; set; }
        public int LowSeasonPrice { get; set; }
        public int HighSeasonPrice { get; set; }
        public Room Room { get; set; }

    }
}
