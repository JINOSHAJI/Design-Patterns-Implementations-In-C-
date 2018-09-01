using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Calculator
{
    //The client 
    class CalculateClient
    {
        private ICalculateInterface calculateInterface;

        //Constructor: assigns strategy to interface
        public CalculateClient(ICalculateInterface strategy)
        {
            calculateInterface = strategy;
        }

        //Executes the strategy
        public int Calculate(int value1, int value2)
        {
            return calculateInterface.Calculate(value1, value2);
        }
    }
}
