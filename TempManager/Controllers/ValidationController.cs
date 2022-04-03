using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext _context;

        public ValidationController(TempManagerContext ctx)
        {
            _context = ctx;
        }

        public JsonResult CheckDate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            Temp temperature = _context.Temps.FirstOrDefault(temp => temp.Date == dt);
            if (temperature != null)
            {
                return Json(true);
            }
            else
            {
                return Json($"The date already exists on the database!!.");
            }
        }
    }
}