using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravellerHelper.Models;
using TravellerHelper.Services;
using TravellerHelper.Services.Database;

namespace TravellerHelper.Controllers
{
    //[Authorize]
    public class HomeController : ControllerBase
    {
        private readonly HomeService _homeService;

        public HomeController(ApplicationContext dbContext, IMapper mapper)
        {
            _homeService = new HomeService(dbContext, mapper);
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult UzakonitNezakonnuyuRekonstrukciyu()
        {
            return View();
        }
        public IActionResult UzakonenieNezakonnyxPostroek()
        {
            return View();
        }
        public IActionResult PriznaniePravaSobstvennostiNaSamovolnuyuPostrojku()
        {
            return View();
        }
        public IActionResult UzakonitIndividualnoeZhiloeStroenie()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
