using System;
using Microsoft.AspNetCore.Mvc;

namespace TravellerHelper.Controllers
{
    public class ControllerBase : Controller
    {
        protected JsonResult SuccessJsonResult()
        {
            return Json(new { Result = "ok" });
        }

        protected JsonResult InvokeException(Exception ex)
        {
            return Json(new
            {
                HasErrors = true,
                Errors = ex.Message
            });
        }
    }
}
