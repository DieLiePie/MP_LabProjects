using System;
using static System.Console;

namespace DLP
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            WriteLine("#1 \nEnter angle");
            float alpha = float.Parse(ReadLine());
            WriteLine("Answer = " + alpha / 180 + "pi");
            //2
            WriteLine("#2  \nEnter angle in radians");
            alpha = float.Parse(ReadLine());
            WriteLine("Answer in degrees = " + alpha * 180);
            //3
            WriteLine("#3 \nЕnter X, A, Y");
            int X = Convert.ToInt32(ReadLine()), A = Convert.ToInt32(ReadLine()), Y = Convert.ToInt32(ReadLine());
            WriteLine("1 kg cost is " + A / X + " " + Y + "kgs cost is " + A / X * Y);
            //4
            WriteLine("#4 \nEnter V1, V2, S, T");
            int V1 = Convert.ToInt32(ReadLine()), V2 = Convert.ToInt32(ReadLine()), S = Convert.ToInt32(ReadLine()), T = Convert.ToInt32(ReadLine());
            WriteLine("Distance after T hours = " + V1 * T + S + V2 * T);
            //5
            WriteLine("#5 \nenter coefficients A!=0 and B: ");
            A = Convert.ToInt32(ReadLine());
            int B = Convert.ToInt32(ReadLine());
            float x = -B / A;
            WriteLine("x = " + x);
            //6
            WriteLine("#6 \nenter coefficients A, B, A1, B1: ");
            int a1 = Convert.ToInt32(ReadLine()), b1 = Convert.ToInt32(ReadLine()), a2 = Convert.ToInt32(ReadLine()), b2 = Convert.ToInt32(ReadLine());
            WriteLine("enter C, C1: ");
            int c1 = Convert.ToInt32(ReadLine()), c2 = Convert.ToInt32(ReadLine());
            float y = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);
            WriteLine("x = " + ((c1 - b1 * y) / a1)+ " y = "+y);
        }
    }
}
