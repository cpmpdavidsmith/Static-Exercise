namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(69);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"{celsius}");
            Console.WriteLine($"{fahrenheit}");
        }
    }
}
