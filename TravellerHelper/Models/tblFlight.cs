using System;
using System.ComponentModel.DataAnnotations.Schema;
using TravellerHelper.Models.Common;

namespace TravellerHelper.Models
{
    public class tblFlight : DatabaseObject
    {
        public DateTime Date { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public int SeatsMax { get; set; }
        public int SeatsReserved { get; set; }
        public decimal Price { get; set; }

        public long CityFromId { get; set; }
        [ForeignKey("CityFromId")]
        public tblCity CityFrom { get; set; }
        public long CityToId { get; set; }
        [ForeignKey("CityToId")]
        public tblCity CityTo { get; set; }
    }
}
