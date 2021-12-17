using System;
using static System.Console;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("#1 \nEnter N: ");
            int N = Convert.ToInt32(ReadLine());
            int[] mas = new int[N];
            int k = 1;
            for (int i = 1; i < N * 2; i += 2)
            {
                mas[i - k] = i;
                k++;
            }
            for (int i = 0; i < N; i++)
                Write(mas[i] + " ");

            WriteLine("#2 \nEnter N: ");
            N = Convert.ToInt32(ReadLine());
            int[] arr = new int[N];
            WriteLine("Enter A: ");
            int A = Convert.ToInt32(ReadLine());
            WriteLine("Enter D: ");
            int D = Convert.ToInt32(ReadLine());
            for (int i = 0; i < N; i++)
            {
                int temp = 1;
                for (int j = 0; j < i; j++)
                    temp *= D;
                arr[i] = A * temp;
            }
            for (int i = 0; i < N; i++)
                Write(arr[i] + " ");

            WriteLine("#3 \nEnter N: ");
            N = Convert.ToInt32(ReadLine());
            int[] ar = new int[N];
            WriteLine("Enter A: "); 
            A = Convert.ToInt32(ReadLine());
            WriteLine("Enter B: ");
            int B = Convert.ToInt32(ReadLine());
            ar[0] = A; ar[1] = B;
            for (int i = 2; i < N; i++)
                ar[i] = ar[i - 1] + ar[i - 2];
            for (int i = 0; i < N; i++)
                Write(ar[i] + " ");

            WriteLine("#4 \nEnter N: ");
            N = Convert.ToInt32(ReadLine());
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
                a[i] = i;
            k = 0;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                    Write(a[i - k] + " ");
                else
                    Write(a[N - i + k] + " ");
                if (i % 2 != 0)
                    k++;
            }

            WriteLine("#5 \nEnter N: "); 
            N = Convert.ToInt32(ReadLine());
            int[] AR = new int[N];
            for (int i = 0; i < N; i++)
                AR[i] = i;
            for (int i = 0; i < N; i++)
                if (i % 2 == 0)
                    Write(AR[i] + " ");
            Write('\n');
            for (int i = 0; i < N; i++)
                if (i % 2 != 0)
                    Write(AR[N - i] + " ");


        }   
    }
}