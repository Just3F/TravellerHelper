using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TravellerHelper.Models;
using TravellerHelper.Services;
using TravellerHelper.Services.Database;

namespace TravellerHelper.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly HomeService _homeService;
        private readonly IMapper _mapper;

        public HomeController(ApplicationContext dbContext, IMapper mapper)
        {
            _homeService = new HomeService(dbContext, mapper);
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult FlightSearch()
        {
            var m = _homeService.FlightSearch();
            return Json(m);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
