using System;
using static System.Console;

namespace _14
{
    class Program
    {
        static int ReadInt()
        {
            return Convert.ToInt32(ReadLine());
        }
        static void Main(string[] args)
        {
            
                WriteLine("№1 \nEnter A: ");
                int A = Convert.ToInt32(ReadLine());
                WriteLine("Enter B: ");
                int B = Convert.ToInt32(ReadLine());
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        WriteLine(i);
                    }
                }

                WriteLine("#2 \nEnter A: ");
                A = Convert.ToInt32(ReadLine());
                WriteLine("Enter B: ");
                B = Convert.ToInt32(ReadLine());
                while (A - B >= 0)
                {
                    A -= B;
                }
                WriteLine("Untaken part = " + A);

                WriteLine("#3 \nEnter N: ");
                int n = Convert.ToInt32(ReadLine()), k = 0, s = 0;
                while (s < n)
                {
                    k++;
                    s += k;
                }
                WriteLine("K = " + k + "sum = " + s);

                WriteLine("#4\nEnter P: ");
                float p = 1 + (float.Parse(ReadLine()) / 100), S = 1000;
                k = 0;
                while (S <= 1100)
                {
                    S *= p;
                    k++;
                }
                WriteLine("Mounths:" +k+ "deposit = "+S);

                WriteLine("№5 \nEnter A: ");
                A = Convert.ToInt32(ReadLine());
                WriteLine("Enter B: ");
                B = Convert.ToInt32(ReadLine());
                while (A != B)
                {
                    if (A > B)
                        A -= B;
                    else
                        B -= A;
                }
                WriteLine("NOD = " + A);

                WriteLine("#6 \nEnter N:");
                int f1 = 1, f2 = 1, f = 0;
                k = 2;
                n = Convert.ToInt32(ReadLine());
                while (f < n)
                {
                    f = f2 + f1;
                    f1 = f2;
                    f2 = f;
                    k++;
                }
                WriteLine("K = " + k);
            
            }
        }
    }
}