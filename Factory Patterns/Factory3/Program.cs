﻿using System;
using System.Reflection;
using Factory3.Autos;
using Factory3.Factories;

namespace Factory3
{
    class Program
    {
        static void Main()
        {
            
            IAutoFactory autoFactory = LoadFactory();

            IAuto car = autoFactory.CreateAutomobile();
            
            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            // configure factories based on the configuration
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }

}