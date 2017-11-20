using System.Collections.Generic;
using AutoMapper;
using TravellerHelper.Services.Database;
using TravellerHelper.ViewModels;

namespace TravellerHelper.Services
{
    public class AdminService : ServiceBase
    {
        public AdminService(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<FlightViewModel> SearchFlights()
        {
            var m = _mapper.Map<List<FlightViewModel>>(_db.tblFlight);
            return m;
        }
    }
}
