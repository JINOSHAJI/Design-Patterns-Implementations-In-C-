using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Calculator
{
    //The interface for the strategies

    public interface ICalculateInterface
    {

        //define method
        int Calculate(int value1, int value2);
    }
}
