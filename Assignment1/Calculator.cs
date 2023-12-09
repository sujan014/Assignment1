using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Calculator : CalculatorBase
    {
        public override int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public override int Multiply(int value1, int value2)
        {
            return value1*value2;
        }

        public override int Subtract(int value1, int value2)
        {
            return value1- value2;
        }
    }
}
