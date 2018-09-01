using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console_App.Singleton
{
    public class SingletonCalculate
    {
        public static SingletonCalculate _instance;
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public SingletonCalculate()
        {
        }

        public static SingletonCalculate Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonCalculate();
                }
                return _instance;
            }
        }
        #region Methods
        public double Addition()
        {
            return ValueOne + ValueTwo;
        }

        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }

        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }

        public double Division()
        {
            return ValueOne / ValueTwo;
        }

        #endregion
    }
}
