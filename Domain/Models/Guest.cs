using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
   public class Guest
    {
        public int Id { get; set; }
        //social security Number(National Number)
        [Required]
        public string SSN { get; set; }
        [Required]
        
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }

        public List<Room> Rooms { get; set; }
        public FamilyMembers FamilyMember { get; set; }


    }
}
