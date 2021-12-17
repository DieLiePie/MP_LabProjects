using System;
using static System.Console;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            WriteLine("#1 \nEnter seconds : ");
            int N = Convert.ToInt32(ReadLine());
            WriteLine($"Answer = {N % 60}");
            //2
            WriteLine("#2 \nEnter number of the current day: ");
            int K = Convert.ToInt32(ReadLine());
            WriteLine($"{K % 7} is weekday number;");
            //3
            WriteLine("#3 \nEnter number of the current day and weekday of 1 january");
            K = Convert.ToInt32(ReadLine());
            N = Convert.ToInt32(ReadLine());
            WriteLine($"{(N + K - 2) % 7 + 1} is weekday number;");
            //4
            WriteLine("#4 \nEnter A, B, C :");
            int A = Convert.ToInt32(ReadLine()), B = Convert.ToInt32(ReadLine()), C = Convert.ToInt32(ReadLine());
            int count = A * B / (C * C);
            WriteLine($"rects = {count} ; {A * B - C * C * count} - untaken part;");
            //5
            WriteLine("#5 \nEnter number of year:");
            N = Convert.ToInt32(ReadLine());
            WriteLine($"{(N % 10 == 0 ? N / 100 : N / 100 + 1)} - century");
        }
    }
}
