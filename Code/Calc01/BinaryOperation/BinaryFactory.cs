using System;
using System.Collections.Generic;
using System.Text;

namespace Calc01
{
    class BinaryFactory
    {
        
        public void CreateBinaryOperation(string opt) {

            BinaryOperation operation = null;
            switch (opt) {
                case "+":
                    operation = new Add();
                    break;
                case "-":
                    operation = new Sub();
                    break;
                case "*":
                    operation = new Mul();
                    break;
                case "/":
                    operation = new Div();
                    break;
            }
        }

        public bool IsFirstOperation(string opt) {
            return false;
        }
    }
}
