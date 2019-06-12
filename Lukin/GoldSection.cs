using System;
using System.Collections.Generic;
using System.Text;

namespace Lukin
{
    class GoldSection
    {
        double phi = (1 + Math.Sqrt(5)) / 2;

        double f(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
        }

       public double findMin(double a,double b,double e)
        {
            double x1;
            double x2;
            while(true)
            {
                x1 = b - (b - a) / phi;
                x2 = a + (b - a) / phi;
                if(f(x1)>=f(x2))
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }
                if(Math.Abs(b-a)<e)
                {
                    break;
                }
            }
            return (a + b) / 2;
        }

       public double findMax(double a,double b,double e)
        {
            double x1;
            double x2;
            while (true)
            {
                x1 = b - (b - a) / phi;
                x2 = a + (b - a) / phi;
                if (f(x1)<=f(x2))
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }
                if (Math.Abs(b-a) < e)
                {
                    break;
                }
            }
            return (a + b) / 2;
        }


    }
}
