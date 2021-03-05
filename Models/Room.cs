using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PASSION_PROJECT_MVP.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public decimal RoomLength { get; set; }
        public decimal RoomWidth { get; set; }
        public bool Demolition { get; set; }
        public int NewWalls { get; set; }

    }
}