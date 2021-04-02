using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
  public  class RoomType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; } 
        [Required]
        public string Descrption { get; set; }
        [Required]
        public int Price { get; set; }
        public Room Room { get; set; }
    }
}
