using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string Descrption { get; set; }
        [Required]
        public int Price { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
