using System;
using static System.Console;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        { 
                WriteLine("#1 \nEnter 1 kg cost");
                float n = Convert.ToInt32(ReadLine());
                for (double i = 0.1; i < 1; i += 0.1)
                {
                    double res = n * i;
                    string result = String.Format("{0:f1}", res);
                    string I = String.Format("{0:f1}", i);
                    WriteLine($"{I} kgs = {result}");
                }

                double p = 1;
                Write("#2 \nEnter N:");
                n = Convert.ToInt32(ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    p = p * (1 + 0.1 * i);
                }
                WriteLine("Result=" + p);

                int rez = 0;
                WriteLine("#3 \nEnter N:");
                n = Convert.ToInt32(ReadLine());
                for (int i = 1; i <= (2 * n - 1); i += 2)
                {
                    rez += i;
                    WriteLine($"Result = {rez}");
                }

                WriteLine("#4 \nEnter A: ");
                float a = float.Parse(ReadLine()), aPow = 1, rezult = 1;
                WriteLine("Enter N: ");
                n = Convert.ToInt32(ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    aPow = a * aPow;
                    rezult += aPow;
                }
                WriteLine($"Result = {rezult}");

                double sum = 1;
                WriteLine("#5 \nEnter N: ");
                n = Convert.ToInt32(ReadLine());
                WriteLine("Enter A: ");
                double A = double.Parse(ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    sum += Math.Pow(-A, i);
                }
                WriteLine($"Result = {sum}");

            
            }
        }
    }
}