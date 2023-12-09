using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class CalculatorBase
    {
        public abstract int Add(int value1, int value2);
        public abstract int Subtract(int value1, int value2);
        public abstract int Multiply(int value1, int value2);

    }
}
