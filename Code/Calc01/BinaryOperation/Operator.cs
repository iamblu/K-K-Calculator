using System;
using System.Collections.Generic;
using System.Text;

namespace Calc01
{
    class Operator
    {
    }

    class Add : BinaryOperation {
        public double GetResult() {
            return NumberA1 + NumberB1;
        }
    }
    class Sub : BinaryOperation {
        public double GetResult()
        {
            return NumberA1 - NumberB1;
        }
    }
    class Div : BinaryOperation {
        public double GetResult()
        {
            if (NumberB1 != 0)
                return NumberA1 + NumberB1;
            else
                throw new Exception("除数不能为零"); 
        }
    }
    class Mul : BinaryOperation {
        public double GetResult()
        {
            return NumberA1 * NumberB1;
        }
    }
}
