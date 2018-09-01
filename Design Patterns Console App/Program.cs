using Design_Patterns_Console_App.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonCalculate.Instance.ValueOne = 12;
            SingletonCalculate.Instance.ValueTwo = 22;

            Console.WriteLine("\n-----------SingletonCalculate-----------\n");
            Console.WriteLine("Addition : " + SingletonCalculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + SingletonCalculate.Instance.Subtraction());
            Console.WriteLine("Multiplication  : " + SingletonCalculate.Instance.Multiplication());
            Console.WriteLine("Division   : " + SingletonCalculate.Instance.Division());

            Console.ReadLine();
            
            Console.WriteLine("\n----------Lazy loaded thread safe implementation------------\n");

            LazySingletonCalculate.Instance.ValueOne = 25;
            LazySingletonCalculate.Instance.ValueTwo = 15;

            Console.WriteLine("Addition : " + LazySingletonCalculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + LazySingletonCalculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + LazySingletonCalculate.Instance.Multiplication());
            Console.WriteLine("Division : " + LazySingletonCalculate.Instance.Division());
            Console.WriteLine("\n----------LazySingletonCalculate END------------\n");

            Console.ReadLine();
        }
    }
}
