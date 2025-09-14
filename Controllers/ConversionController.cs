using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            return View(new TemperatureModel());
        }

        [HttpPost]
        public IActionResult Fahrenheit(TemperatureModel model)
        {
            if (!model.Fahrenheit.HasValue)
            {
                ViewBag.Error = "Please enter a value.";
                return View(model);
            }

            model.Celsius = (model.Fahrenheit.Value - 32) * 5 / 9;
            return View(model);
        }
    }
}
