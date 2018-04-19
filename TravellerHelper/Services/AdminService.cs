using AutoMapper;
using TravellerHelper.Services.Database;

namespace TravellerHelper.Services
{
    public class AdminService : ServiceBase
    {
        public AdminService(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

      
    }
}
