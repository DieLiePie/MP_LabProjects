using System;
using static System.Console;
using static System.Math;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            WriteLine("#1 \nEnter A and B:");
            int A = Convert.ToInt32(ReadLine()), B = Convert.ToInt32(ReadLine());
            if (A == B)
            {
                WriteLine("0,0 ");
            }
            else
            {
                WriteLine(Max(A,B) + Max(A,B));
            }
            //2
            WriteLine("#2 \nEnter 3 numbers: ");
            A = Convert.ToInt32(ReadLine());
            B = Convert.ToInt32(ReadLine());
            int C = Convert.ToInt32(ReadLine());
            WriteLine($"{Max(A, B) + Max(B, C)}");
            //3
            WriteLine("#3 \nEnter A:");
            int xA = Convert.ToInt32(ReadLine()), yA = Convert.ToInt32(ReadLine());
            WriteLine("Enter B:");
            int xB = Convert.ToInt32(ReadLine()), yB = Convert.ToInt32(ReadLine());
            WriteLine("Enter C:");
            int xC = Convert.ToInt32(ReadLine()), yC = Convert.ToInt32(ReadLine());
            double distAB = Sqrt(Pow(xB - xA, 2) + Pow(yB - yA, 2));
            double distAC = Sqrt(Pow(xC - xA, 2) + Pow(yC - yA, 2));
            if (distAB < distAC)
            {
                WriteLine("B" + distAB);
            }
            else
                WriteLine("C" + distAC);
            //4
            WriteLine("#4 \nEnter coordinates:");
            int x = Convert.ToInt32(ReadLine()), y = Convert.ToInt32(ReadLine());
            if (x > 0 && y > 0)
                WriteLine("1");
            else if (x < 0 && y > 0)
                WriteLine("2");
            else if (x < 0 && y < 0)
                WriteLine("2");
            else 
                WriteLine("4");
            //5
            WriteLine("#5 \nEnter number:");
            x = Convert.ToInt32(ReadLine());
            if (x > 0)
            {
                if (x % 2 == 0)
                    WriteLine("положительное четное число");
                else
                    WriteLine("положительное нечетное число");
            }
            else if (x < 0)
            {
                if (x % 2 == 0)
                    WriteLine("отрицательное четное число");
                else
                    WriteLine("отрицательное нечетное число");
            }
            else
                WriteLine("null");
            //6
            WriteLine("#6 \nEnter number:");
            x = Convert.ToInt32(ReadLine());
            int temp = x, cnt = 0;
            while (temp > 0)
            {
                temp /= 10;
                cnt += 1;
            }
            if (x % 2 == 0)
            {
                if (cnt == 1)
                    WriteLine("четное однозначное число");
                else if (cnt == 2)
                    WriteLine("четное двузначное число");
                else
                    WriteLine("четное трехзначное число");
            }
            else
            {

                if (cnt == 1)
                    WriteLine("нечетное однозначное число");
                else if (cnt == 2)
                    WriteLine("нечетное двузначное число");
                else
                    WriteLine("нечетное трехзначное число");
            }
        }
    }
}
