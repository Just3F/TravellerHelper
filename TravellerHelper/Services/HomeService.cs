using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TravellerHelper.Services.Database;
using TravellerHelper.ViewModels;

namespace TravellerHelper.Services
{
    public class HomeService : ServiceBase
    {
        public HomeService(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<FlightViewModel> FlightSearch()
        {
            var m = _mapper.Map<List<FlightViewModel>>(_db.tblFlight);
            return m;
        }
    }
}
