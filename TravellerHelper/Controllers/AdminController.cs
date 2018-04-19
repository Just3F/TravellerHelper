using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravellerHelper.Services;
using TravellerHelper.Services.Database;
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
    }
}
