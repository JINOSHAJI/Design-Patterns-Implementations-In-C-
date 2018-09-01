using Factory1.Autos;
using System;

namespace Factory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of car");
            string carName = Console.ReadLine();

          //  string carName = args[0];

            IAuto car = GetCar(carName);
            car.TurnOn();
            car.TurnOff();
        }

        static IAuto GetCar(string carName)
        {
            switch (carName)
            {
                case "bmw":
                    return new BMW335Xi();
                case "mini":
                    return new MiniCooper();
                case "audi":
                    return new AudiTTS();
                default:
                    return new NullCar();
            }    
        }
    }
}
