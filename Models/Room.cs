using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public bool DrywallRepair { get; set; }
        public bool DrywallInstallation { get; set; }
        public string FloorInstallation { get; set; }
        public bool NewWindows { get; set; }
        public bool NewDoors { get; set; }

        //public byte[] Image { get; set; }

        [ForeignKey("House")]
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}