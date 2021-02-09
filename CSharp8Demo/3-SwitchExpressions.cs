using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Demo
{
    class SwitchExpressions
    {
        public static double DoMath(double x, double y, MathType math)
        {
            double result;

            result = math switch
            {
                MathType.Add => x + y,
                MathType.Subtract => x - y,
                MathType.Multiply => x * y,
                MathType.Divide => x / y,
                _ => throw new Exception("Invalid Operation")
            };

            //switch (math)
            //{
            //    case MathType.Add:
            //        result = x + y;
            //        break;
            //    case MathType.Subtract:
            //        result = x + y;
            //        break;
            //    case MathType.Multiply:
            //        result = x + y;
            //        break;
            //    case MathType.Divide:
            //        result = x + y;
            //        break;
            //    default:
            //        throw new Exception("Invalid operation");
            //        break;
            //}
            return result;
        }
    }

    enum MathType{
        Add,
        Subtract,
        Multiply,
        Divide
    };
}
