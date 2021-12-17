using System;
using static System.Console;
namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            WriteLine("#1 \nEnter A and B:");
            int A = Convert.ToInt32(ReadLine()), B = Convert.ToInt32(ReadLine());
            if (A>2 && B <= 3)
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
            //2
            WriteLine("#2 \nEnter A and B and C: ");
            A = Convert.ToInt32(ReadLine());
            B = Convert.ToInt32(ReadLine());
            int C = Convert.ToInt32(ReadLine());
            if (A < B && B < C)
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
            //3
            WriteLine("#3 \nEnter number");
            int X = Convert.ToInt32(ReadLine());
            if (X % 2 == 0 && X / 10 > 0 && X / 100 == 0)
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
            //4
            WriteLine("#4 \nEnter 3-digit number");
            string x = ReadLine();
            if (x[0] < x[1] && x[1] < x[2] || x[0] > x[1] && x[1] > x[2])
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
            //5
            WriteLine("#5 \nEnter 4-digit number");
            X = Convert.ToInt32(ReadLine());
            int reverse = (X % 10 * 10) + (X % 100 / 10);
            if (X / 100 == reverse)
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
            //6
            WriteLine("#6 \nEnter A and B and C;");
            A = Convert.ToInt32(ReadLine());
            B = Convert.ToInt32(ReadLine());
            C = Convert.ToInt32(ReadLine());
            if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B))
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
            //7
            WriteLine("#7 \nEnter A and B and C;");
            A = Convert.ToInt32(ReadLine());
            B = Convert.ToInt32(ReadLine());
            C = Convert.ToInt32(ReadLine());
            if (A + B > C || A + C > B || B + C > A )
            {
                WriteLine("Correct");
            }
            else
            {
                WriteLine("Incorrect");
            }
        }
    }
}
