using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravellerHelper.Services;
using TravellerHelper.Services.Database;
using TravellerHelper.ViewModels;
using TravellerHelper.ViewModels.Constants;

namespace TravellerHelper.Controllers
{
    [Authorize(Roles = UserRolesConstants.Administrator)]
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

        [HttpGet]
        public IActionResult Flight(long id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Flight(FlightViewModel model)
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
