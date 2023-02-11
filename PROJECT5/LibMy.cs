using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT5
{
    static class LibMy
    {
        public static double Project1(double a, double b, double c)
        {

            double p = (a + b + c);

            double K = (p * (p - a) * (p - b)) / a * b;

            return K;
        }
        public static double Project2(double a, double b, int c)
        {
            double answer;
            switch (c)
            {
                case 1:
                    answer = a + b;
                    return answer;
                case 2:
                    answer = a - b;
                    return answer;
                case 3:
                    answer = a * b;
                    return answer;
                default:
                    return 0;
            }
        }
        public static double Project3(double xn, double xk, double x)
        {
            double S = 1, f;
            int n, i;

            for (n = 1; n <= xk*10; n++)
            {
                f = 1;
                for (i = 1; i <= 2 * n; i++)
                { f = f * i; }
                S = S + Math.Pow(-1, n) * Math.Pow(x, 2 * n) / f;
            }
            return S;
        }

        public static double Project31(double xn, double xk, double x)
        {
            double Y = Math.Cos(x);
            return Y;
        }
        public static int  Project4(int K, int L, int n, int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (!(K <= i && i <= L))
                {
                    sum += mas[i];
                }
            }
            return sum;
        }

    }
}
