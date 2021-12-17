using System;
using static System.Console;
namespace _15
{
    class Program
    {
        static double PowerA3(double A, double B)
        {
            B = A * A * A;
            return B;
        }

        static int Sign(double X)
        {
            if (X > 0)
                return 1;
            else if (X == 0)
                return 0;
            else
                return -1;
        }

        static double RingS(double R1, double R2)
        {
            double pi = 3.14;
            return (pi * R1 * R1) - (pi * R2 * R2);
        }

        static int Quarter(double x, double y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else return 4;
        }

        static double Fact2(int N)
        {
            double res = 1;
            if (N%2 != 0)
                for (int i = 1; i <= N; i += 2)
                    res *= Convert.ToDouble(i);
            else 
                for (int i = 2; i <= N; i += 2)
                    res *= Convert.ToDouble(i);
            return res;

        }
        static void Main(string[] args)
        {
            WriteLine("#1");
            double A = 0, B = 0;
            for (int i = 0; i < 5; i++)
            {
                WriteLine("Enter A: ");
                A = double.Parse(ReadLine());
                WriteLine(PowerA3(A, B));
            }

            WriteLine("#2 \nEnter A and B: ");
            A = double.Parse(ReadLine());
            B = double.Parse(ReadLine());
            WriteLine(Sign(A) + Sign(B));

            WriteLine("#3");
            for (int i = 0; i < 3; i++)
            {
                WriteLine("Enter R1 and R2: ");
                double R1 = double.Parse(ReadLine()), R2 = double.Parse(ReadLine());
                WriteLine(RingS(R1, R2));
            }

            WriteLine("#4");
            for (int i = 0; i < 3; i++)
            {
                WriteLine("Enter x and y: ");
                double x = double.Parse(ReadLine()), y = double.Parse(ReadLine());
                WriteLine(Quarter(x, y));
            }

            WriteLine("#5 \nEnter N: ");
            int N = Convert.ToInt32(ReadLine());
            WriteLine(Fact2(N));


        }
    }
}