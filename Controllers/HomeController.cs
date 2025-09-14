using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Initial load: both fields empty
            return View(new TemperatureModel());
        }

        [HttpPost]
        public IActionResult Index(TemperatureModel model)
        {
            bool hasF = model.Fahrenheit.HasValue;

            // Only Fahrenheit to Celsius conversion
            if (!hasF)
            {
                ModelState.AddModelError(string.Empty, "Please enter a Fahrenheit value.");
            }
            else if (ModelState.IsValid && model.Fahrenheit != null)
            {
                model.Celsius = TemperatureModel.FahrenheitToCelsius(model.Fahrenheit.Value);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Clear()
        {
            // Reset to clean form: both fields empty
            ModelState.Clear();
            return View("Index", new TemperatureModel());
        }
    }
}