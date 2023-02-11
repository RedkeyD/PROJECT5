using System;
using PROJECT5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT5
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what project you are want to see: ");
            Console.WriteLine("1.First project");
            Console.WriteLine("2.Second project");
            Console.WriteLine("3.Third project");
            Console.WriteLine("4.Fourth project");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter a, b and c: ");
                    Console.WriteLine("Please enter a, b and c: ");
                    Double a = Convert.ToDouble(Console.ReadLine());
                    Double b = Convert.ToDouble(Console.ReadLine());
                    Double c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("K = " + LibMy.Project1(a, b, c));
                    Console.ReadKey();

                    break;
                case 2:
                    Console.WriteLine("Enter 1 digit: ");
                    Double d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter 2 digit: ");
                    Double e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose operation: ");
                    Console.WriteLine("1.add ");
                    Console.WriteLine("2.subtract ");
                    Console.WriteLine("3.multiply ");
                    int f = Convert.ToInt32(Console.ReadLine());

                    if(f<1 && f > 3) { Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 3."); }

                    Console.WriteLine((LibMy.Project2(d, e, f).ToString()));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("Enter a xn = ");
                    double xn = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter a xk = ");
                    double xk = Convert.ToDouble(Console.ReadLine());

                    double h = (xk - xn) / 10;

                    for (double x = xn; x <= xk; x += h)
                    {
                        double Y = LibMy.Project31(xn, xk, x);
                        double S = LibMy.Project3(xn, xk, x);
                        Console.WriteLine("When x = {0}, S(x) = {1}, Y(x) = {2}", x, S, Y);
                    }
                    Console.ReadKey();
                        break;
                case 4:
                    Console.Write("Enter size of array n = ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] mas = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter element of array mas[{0}] = ", i);
                        mas[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("Enter a K = ");
                    int K = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter a L = ");
                    int L = Convert.ToInt32(Console.ReadLine());

                    int sum = LibMy.Project4(K, L, n, mas);
                    Console.WriteLine($"Sum of array is: {sum}");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 4.");
                    break;
            }
        }
    }
}
