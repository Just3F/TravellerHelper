using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TravellerHelper.Services.Database;

namespace TravellerHelper.Services
{
    public class ServiceBase
    {
        protected ApplicationContext _db { get; set; }
        protected IMapper _mapper { get; set; }
    }
}
