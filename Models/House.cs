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

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<Room> Rooms { get; set; }

    }
}