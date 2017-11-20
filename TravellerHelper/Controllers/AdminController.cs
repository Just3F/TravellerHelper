using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TravellerHelper.Services;
using TravellerHelper.Services.Database;
using TravellerHelper.ViewModels;

namespace TravellerHelper.Controllers
{
    public class AdminController : ControllerBase
    {
        private readonly AdminService _adminService;

        public AdminController(ApplicationContext dbContext, IMapper mapper)
        {
            _adminService = new AdminService(dbContext, mapper);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Flights()
        {
            return View();
        }

        public IActionResult Flight(long id)
        {
            return View();
        }

        public JsonResult SearchFlights()
        {
            var m = _adminService.SearchFlights();
            return Json(m);
        }
    }
}
