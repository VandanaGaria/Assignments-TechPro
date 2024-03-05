using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pattern 1 - Hollow Square
            Console.WriteLine("Pattern 1 - Hollow Square");
            Console.WriteLine();
            Pattern1();
            Console.WriteLine();

            //Pattern 2 - Number Triangle
            Console.WriteLine("Pattern 2 - Number Triangle");
            Console.WriteLine();
            Pattern2();
            Console.WriteLine();

            //Pattern 3 - Increasing Number Triangle
            Console.WriteLine("Pattern 3 - Increasing Number Triangle");
            Console.WriteLine();
            Pattern3();
            Console.WriteLine();

            //Pattern 4 - Number-increasing reverse Pyramid Pattern
            Console.WriteLine("Pattern 4 - Number-increasing reverse Pyramid Pattern");
            Console.WriteLine();
            Pattern4();
            Console.WriteLine();

            //Pattern 5 - Number-changing Pyramid Pattern
            Console.WriteLine("Pattern 5 - Number-changing Pyramid Pattern");
            Console.WriteLine();
            Pattern5();
            Console.WriteLine();

            //Pattern 6 - Zero-One Triangle Pattern
            Console.WriteLine("Pattern 6 - Zero-One Triangle Pattern");
            Console.WriteLine();
            Pattern6();
            Console.WriteLine();

            //Pattern 7 - Palindrome Triangle Pattern
            Console.WriteLine("Pattern 7 - Palindrome Triangle Pattern");
            Console.WriteLine();
            Pattern7();
            Console.WriteLine();

            //Pattern 8 - Rhombus Pattern
            Console.WriteLine("Pattern 8 - Rhombus Pattern");
            Console.WriteLine();
            Pattern8();
            Console.WriteLine();

            //Pattern 9 - Diamond Star Pattern
            Console.WriteLine("Pattern 9 - Diamond Star Pattern");
            Console.WriteLine();
            Pattern9();
            Console.WriteLine();

            //Pattern 10 - Mirror Image Triangle Pattern
            Console.WriteLine("Pattern 10 - Mirror Image Triangle Pattern");
            Console.WriteLine();
            Pattern10();
            Console.WriteLine();

            //Pattern 11 - Hollow Triangle Pattern
            Console.WriteLine("Pattern 11 - Hollow Triangle Pattern");
            Console.WriteLine();
            Pattern11();
            Console.WriteLine();

            //Pattern 12 - Hollow Reverse Triangle Pattern
            Console.WriteLine("Pattern 12 - Hollow Reverse Triangle Pattern");
            Console.WriteLine();
            Pattern12();
            Console.WriteLine();

            //Pattern 13 - Hollow Diamond Pyramid
            Console.WriteLine("Pattern 13 - Hollow Diamond Pyramid");
            Console.WriteLine();
            Pattern13();
            Console.WriteLine();

            //Pattern 14 - Hollow Hourglass Pattern
            Console.WriteLine("Pattern 14 - Hollow Hourglass Pattern");
            Console.WriteLine();
            Pattern14();
            Console.WriteLine();


            //Pattern 15 - Pascal Triangle
            Console.WriteLine("Pattern 15 - Pascal Triangle");
            Console.WriteLine();
            Pattern15();
            Console.WriteLine();

        }

        static void Pattern1()
        {
            int height = 5;
            int width = 6;

            // for  row
            for (int i = 0; i < height; i++)
            {
                // for  column 
                for (int j = 0; j < width; j++)
                {

                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Pattern2()
        {
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
                // to print spaces
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }

                //prints the number 
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }

                //next line 
                Console.WriteLine();
            }
        }

        static void Pattern3()
        {
            int row = 6;
            //for rows
            for (int i = 1; i <= row; i++)
            {
                //for column
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                //for next line to printed by the pattern
                Console.WriteLine(" ");

            }
        }


        static void Pattern4()
        {
            int row = 6;

            //for rows
            for (int i = 0; i < row; i++)
            {
                //for columns 
                for (int j = row; j > i; j--)
                {
                    Console.Write(row - j + 1 + " ");
                }

                //next line 
                Console.WriteLine(" ");
            }
        }

        static void Pattern5()
        {
            int row = 6;
            int n = 1;

            //for rows
            for (int i = 1; i <= row; i++)
            {
                //for columns
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n + " ");
                    n = n + 1;
                }

                //next line 
                Console.WriteLine(" ");
            }

        }

        static void Pattern6()
        {
            int start = 1;
            int row = 5;
            //for rows
            for (int i = 0; i <= row; i++)
            {
                if (i % 2 == 0)
                {
                    start = 1;
                }
                else
                {
                    start = 0;
                }

                for (int j = 0; j <= i; j++)
                {

                    Console.Write(start + " ");
                    start = 1 - start;
                }
                Console.WriteLine(" ");
            }
        }

        static void Pattern7()
        {
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
                // for spaces
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write("  ");
                }

                // decreasing numbers
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k + " ");
                }

                // increasing numbers
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(l + " ");
                }

                Console.WriteLine();
            }
        }

        static void Pattern8()
        {
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
                // for spaces
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 1; k <= row; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        static void Pattern9()
        {

            int N =5;

            //for erected pyramid

            // for the rows.
            for (int i = 0; i < N; i++)
            {
                //for spaces
                for (int j = 0; j < N - i - 1; j++)
                {
                    Console.Write(" ");
                }

                //  printing the stars in each row
                for (int j = 0; j < 2 * i + 1; j++)
                {

                    Console.Write("*");
                }

                //next line
                Console.WriteLine(" ");

            }

            
            //for inverted pyramid
            //for rows
            for (int i = 0; i < N; i++)
            {
                //for spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // printing the stars in each row
                for (int j = 0; j < 2 * N - (2 * i + 1); j++)
                {

                    Console.Write("*");
                }


                Console.WriteLine();
            }


        } 

        static void Pattern10()
        {
            int N = 6;

            //for inverted pyramid
            //for rows
            for (int i = 0; i < N; i++)
            {
                //for spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // printing increasing number
                for (int j = i+1; j <=N; j++)
                {

                    Console.Write(j+" ");
                }


                Console.WriteLine();
            }

            //for erected pyramid

            // for the rows.
            for (int i = 1; i < N; i++)
            {
                //for spaces
                for (int j = 1; j < N- i ; j++)
                {
                    Console.Write(" ");
                }

                //  printing the increasing number 
                for (int j = N-i; j <=  N; j++)
                {

                    Console.Write(j+" ");
                }

                //next line
                Console.WriteLine(" ");

            }

        }

        static void Pattern11()
        {
            int n = 6;
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                // Print stars
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }


        static void Pattern12()
        {
            int n = 6;
            for (int i = n; i >= 1; i--)
            {
                // Print spaces
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                // Print stars or spaces
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        static void Pattern13()
        {
            int n = 6;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Pattern14()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                // Print  spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars or spaces
                for (int j = 0; j < n - i; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }

            // Lower half of the hourglass
            for (int i = n - 2; i >= 0; i--)
            {
                // Print  spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars or spaces
                for (int j = 0; j < n - i; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }



        static void Pattern15()
        {
            int N = 4;
            for(int i = 1; i<=N; i++)
            {
                int b = 1;
                for(int j = 0; j <= N-i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k<=i; k++)
                {
                    Console.Write(b + " ");
                    b = b * (i - k) / k;
                }
                Console.WriteLine() ;
            }
        }
    }
}
