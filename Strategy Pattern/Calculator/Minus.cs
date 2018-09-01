using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Calculator
{
    //Strategy 1: Minus
    class Minus : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            //define logic
            return value1 - value2;
        }
    }

}
