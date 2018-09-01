using Factory2.Autos;
using System;

namespace Factory2
{
    /// <summary>
    /// simple factory
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of car");
            string carName = Console.ReadLine();
            //string carName  = args[0];

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();
        }
    }
}
