using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Class1
    {
        public static double Plus(double first, double second)
        {
            return first + second;
        }

        public static double Minus(double first, double second)
        {
            return first - second;
        }

        public static double Umnoj(double first, double second)
        {
            return first * second;
        }

        public static double Delit(double first, double second)
        {
            if (second == 0) throw new DivideByZeroException();
            return first / second;
        }
    }
}
