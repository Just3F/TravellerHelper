using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravellerHelper.ViewModels
{
    public class FlightViewModel
    {
        public long PKID { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public DateTime Date { get; set; }
        public int SeatsMax { get; set; }
        public int SeatsReserved { get; set; }
        public int AvailableSeats => SeatsMax - SeatsReserved;
        public decimal Price { get; set; }
        public long CityFromId { get; set; }
        public long CityToId { get; set; }
    }
}
