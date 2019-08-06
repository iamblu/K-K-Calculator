using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.UnaryOperation
{
    class Operator
    {
    }
    class Square : UnaryOperation{
        public double GetResult()
        {

            return Number1 * Number1;
        }
    }
    class Negate : UnaryOperation {
        public double GetResult()
        {
            if (Number1 != 0)
                return 1 / Number1;
            else
                throw new Exception("除数不能为零");
        }
    }
    class Percent : UnaryOperation {
        public double GetResult()
        {

            return Number1 * Number1;
        }
    }
    class SquareBoot : UnaryOperation {
        public double GetResult()
        {
            if (Number1 > 0)
                return Math.Sqrt(Number1);
            else
                throw new Exception("无效输入");
        }
    }
}
