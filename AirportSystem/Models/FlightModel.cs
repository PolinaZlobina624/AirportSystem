using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSystem.Models
{
    public class FlightModel
    {
        public string Departure { get; set; } = "";
        public string Destination { get; set; } = "";
        public DateTime DepartsAt { get; set; }
        public DateTime ArrivesAt { get; set; }
    }
}
