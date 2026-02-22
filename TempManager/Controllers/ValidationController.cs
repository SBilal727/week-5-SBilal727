using Microsoft.AspNetCore.Mvc;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext context;
        public ValidationController(TempManagerContext ctx) => context = ctx;

     
             public JsonResult CheckDate(string date)
        {
            var temp = context.Temps.FirstOrDefault(t => t.Date.ToString() == date);
            
            if (temp == null)
            {
                TempData["okDate"] = true;
                return Json(true);
            }
            else
                return Json("That date already exists.");
        }








    }
    }

