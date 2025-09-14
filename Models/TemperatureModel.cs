namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        public double? Fahrenheit { get; set; }
        public double? Celsius { get; set; }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    // Only Fahrenheit to Celsius conversion required
    }
}