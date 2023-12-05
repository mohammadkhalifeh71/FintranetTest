using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Congestion.Domain
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SSNNumber { get; set; }
        public DateTime DateAndTime { get; set; }
        public List<Toll> Tolls { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
