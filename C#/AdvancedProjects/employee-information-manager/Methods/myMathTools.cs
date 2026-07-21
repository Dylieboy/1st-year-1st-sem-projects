using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMathTools
{
    public static class MathTools
    {
        public static double Add (double x , double y)
        {
            double ans = x + y;
            return ans;
        }//Plus
        public static double Subtrack(double x, double y)
        {
            double ans = x - y;
            return ans;
        }//Minus
        public static double Divide(double x, double y)
        {
            double ans = x / y;
            return ans;
        }//Divide
        public static double Multiply(double x, double y)
        {
            double ans = x * y;
            return ans;
        }//Multiply
        public static double Path(double x, double y)
        {
            //formula = x^2 = side1^2 + side2^2
            double x_2 = (x * x) + (y * y);
            double a = Math.Round(Math.Sqrt(x_2));
            Console.WriteLine($"Answer is : {a}");
            return a;
        }//Pythagoras
        public static string ToBinaryDecimal (long decimalNum)
        {
            //convert decimal to binary
            string binary = " ";
            if (decimalNum == 0)
            {
                return "0";
            }
            while (decimalNum > 0)
            {
                binary += (decimalNum % 2);
                decimalNum /= 2;
            }return binary; 
        }//Convert Decimal => Binary
        public static double ToCelcuis(double fahrenheit)
        {
            double celcuis = (fahrenheit - 32) * 5 /9;
            return Math.Round(celcuis,2);
        }//Convert Fahrenheit => Celcuis
        public static double ToFahrenheit(double celcuis)
        {
            double fahrenheit = (celcuis * (9 / 5)) + 32;
            return Math.Round(fahrenheit,2);
        }//Convert Celcuis => Fahrenheit
       
    }//End MathTools

    public static class TravelMath
    {
       
    }
}
