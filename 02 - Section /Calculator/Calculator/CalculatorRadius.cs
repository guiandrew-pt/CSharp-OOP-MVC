using System;
namespace Calculator
{
    public class CalculatorRadius
	{
        public static double PI = 3.14;

        public static double Circumference(double r)
        {
            return 2.0 * PI * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, 3);
        }
    }
}

