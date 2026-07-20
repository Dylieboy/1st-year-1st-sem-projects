using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMathTools
{
    public static class MathTools
    {
        public static double Path(double x, double y)
        {
            //formula = x^2 = side1^2 + side2^2
            double x_2 = (x * x) + (y * y);
            double a = Math.Round(Math.Sqrt(x_2));
            Console.WriteLine($"Answer is : {a}");
            return a;
        }//pathogorism
    }//End MathTools
}
