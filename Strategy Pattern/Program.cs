using Strategy_Pattern.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateClient minusClient = new CalculateClient(new Minus());

            Console.WriteLine("Minus: " + minusClient.Calculate(7, 1).ToString());

            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus: " + plusClient.Calculate(7, 1).ToString());
            // Wait for user
            Console.ReadKey();
        }
    }
}
