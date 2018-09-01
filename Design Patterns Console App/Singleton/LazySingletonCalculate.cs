using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console_App.Singleton
{
    public class LazySingletonCalculate
    {
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        private LazySingletonCalculate()
        {
        }

        public static LazySingletonCalculate Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
            }
            internal static readonly LazySingletonCalculate Instance = new LazySingletonCalculate();
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
