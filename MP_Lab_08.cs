using System;
using static System.Console;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            WriteLine("#1 \nEnter bytes :");
            int bytes = Convert.ToInt32(ReadLine());
            WriteLine($"{bytes} Bytes = {bytes / 1024} KiloByte(s)");
            //2
            WriteLine("#2 \nEnter A and B (A>B):");
            int A = Convert.ToInt32(ReadLine()), B = Convert.ToInt32(ReadLine());
            WriteLine($"Answer = {A / B}");
            //3
            WriteLine("#3 \nEnter A and B (A>B):");
            A = Convert.ToInt32(ReadLine()); 
            B = Convert.ToInt32(ReadLine());
            WriteLine($"Answer = {A - (A / B * B)}");
            //4
            WriteLine("#4 \nEnter number");
            int number = Convert.ToInt32(ReadLine());
            int reverse = number % 10 * 10 + number / 10;
            WriteLine($"Reversed number is {reverse}");
            //5
            WriteLine("#5 \nEnter 3-digit number:");
            number = Convert.ToInt32(ReadLine());
            WriteLine($"Answer is {number % 100 * 10 + number / 100}");
        }
    }
}
