using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class FamilyMembers
    {
        public int Id { get; set; }
        public int Adults { get; set; }
        public int children { get; set; }
        public int GuestId { set; get; }
        public Guest Guest { get; set; }
    }
}
