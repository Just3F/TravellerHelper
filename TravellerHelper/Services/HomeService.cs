using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

    }
}
