using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, b1, c1;
            string d;
            string[] num1 = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] num2 = new string[] { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eigty", "ninety" };
            string[] num3 = new string[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            
                Console.WriteLine("#1 ");
                Console.WriteLine("Enter the date of the month");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of the month");
                b = Convert.ToInt32(Console.ReadLine());
                string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                if (a <= 0 | a > 31)
                    Console.WriteLine("Date entry error. This date cannot exist\n");
                else if (a == 31 & (b == 2 | b == 4 | b == 6 | b == 9 | b == 11))
                    Console.WriteLine("Date entry error. This date cannot exist\n");
                else if (a >= 29 & b == 2)
                    Console.WriteLine("Date entry error. This date cannot exist\n");
                else
                    Console.WriteLine($"The date you entered is {a} of {months[b - 1]}\n");

                Console.WriteLine("Task 2");
                Console.WriteLine("Ener direction\nn — north\nw - west\ns - south\ne - east\n");
                d = Console.ReadLine();
                Console.WriteLine("Enter the movement");
                a = int.Parse(Console.ReadLine());
                switch (d)
                {
                    case "n":
                        switch (a)
                        {
                            case -1:
                                Console.WriteLine($"Direction of the robot is East\n");
                                break;
                            case 0:
                                Console.WriteLine($"Direction of the robot is North\n");
                                break;
                            case 1:
                                Console.WriteLine($"Direction of the robot is West\n");
                                break;
                            default:
                                Console.WriteLine("Movement error");
                                break;
                        }
                        break;
                    case "w":
                        switch (a)
                        {
                            case -1:
                                Console.WriteLine($"Direction of the robot is North\n");
                                break;
                            case 0:
                                Console.WriteLine($"Direction of the robot is West\n");
                                break;
                            case 1:
                                Console.WriteLine($"Direction of the robot is South\n");
                                break;
                            default:
                                Console.WriteLine("Movement error");
                                break;
                        }
                        break;
                    case "s":
                        switch (a)
                        {
                            case -1:
                                Console.WriteLine($"Direction of the robot is West\n");
                                break;
                            case 0:
                                Console.WriteLine($"Direction of the robot is South\n");
                                break;
                            case 1:
                                Console.WriteLine($"Direction of the robot is East\n");
                                break;
                            default:
                                Console.WriteLine("Movement error");
                                break;
                        }
                        break;
                    case "e":
                        switch (a)
                        {
                            case -1:
                                Console.WriteLine($"Direction of the robot is South\n");
                                break;
                            case 0:
                                Console.WriteLine($"Direction of the robot is East\n");
                                break;
                            case 1:
                                Console.WriteLine($"Direction of the robot is North\n");
                                break;
                            default:
                                Console.WriteLine("Movement error");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Direction error");
                        break;
                }


                Console.WriteLine("Task 3");
                Console.WriteLine("Enter number");
                a = Convert.ToInt32(Console.ReadLine());
                b = Math.DivRem(a, 10, out c);
                if (a > 10 & a < 20)
                    Console.WriteLine($"Entered task is {num3[c - 1]}\n");
                else if (a > 20 & a < 40)
                    Console.WriteLine($"Entered task is {num2[b - 1]}-{num1[c - 1]}\n");
                else if (c == 0 & b <= 4)
                    Console.WriteLine($"Entered task is {num2[b - 1]}\n");
                else
                    Console.WriteLine("There is no such task\n");

                Console.WriteLine("Task 4.");
                Console.WriteLine("Enter number");
                a = Convert.ToInt32(Console.ReadLine());
                b = Math.DivRem(a, 100, out c);
                b1 = Math.DivRem(c, 10, out c1);
                if (a >= 100 & a < 1000)
                {
                    if (c > 10 & c < 20)
                        Console.Write($"Entered number is {num1[b - 1]} hundred {num3[c1 - 1]} \n");
                    else if (c1 == 0 & b1 <= 9)
                        Console.WriteLine($"Entererd number is {num1[b - 1]} hundred {num2[b1 - 1]} \n");
                    else if (c > 20 & c < 99)
                        Console.Write($"Entered number is {num1[b - 1]} hundred {num2[b1 - 1]}-{num1[c1 - 1]} \n");
                    else if (c <= 9)
                        Console.Write($"Entered number is {num1[b - 1]} hundred {num1[c - 1]} \n");
                }
                else
                    Console.WriteLine("The number must be in the range from 100 to 999\n");

                Console.WriteLine("Task 5.");
                Console.WriteLine("Enter number");
                a = Convert.ToInt32(Console.ReadLine());
                string[] color = new string[] { "White", "Black", "Green", "Red", "Yellow" };
                string[] animal = new string[] { "Rat", "Cow", "Tiger", "Hare", "Dragon", "Snake", "Horse", "Lamb", "Monkey", "Hen", "Dog", "Pig" };
                b = a % 10;
                b /= 2;
                c = (a + 8) % 12;
                Console.WriteLine($"The Year of the {color[b]} {animal[c]}\n");


            
        }
    }
}
