using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PASSION_PROJECT_MVP.Models
{
    public class House
    {
        public int HouseId { get; set; }
        public string Address { get; set; }

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Room> Rooms { get; set; }

    }
}