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
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            //Pattern 1 - Hollow Square
            Console.WriteLine("Pattern 1 - Hollow Square");
            Console.WriteLine();
            Pattern1(n);
            Console.WriteLine();

            //Pattern 2 - Number Triangle
            Console.WriteLine("Pattern 2 - Number Triangle");
            Console.WriteLine();
            Pattern2(n);
            Console.WriteLine();

            //Pattern 3 - Increasing Number Triangle
            Console.WriteLine("Pattern 3 - Increasing Number Triangle");
            Console.WriteLine();
            Pattern3(n);
            Console.WriteLine();

            //Pattern 4 - Number-increasing reverse Pyramid Pattern
            Console.WriteLine("Pattern 4 - Number-increasing reverse Pyramid Pattern");
            Console.WriteLine();
            Pattern4(n);
            Console.WriteLine();

            //Pattern 5 - Number-changing Pyramid Pattern
            Console.WriteLine("Pattern 5 - Number-changing Pyramid Pattern");
            Console.WriteLine();
            Pattern5(n);
            Console.WriteLine();

            //Pattern 6 - Zero-One Triangle Pattern
            Console.WriteLine("Pattern 6 - Zero-One Triangle Pattern");
            Console.WriteLine();
            Pattern6(n);
            Console.WriteLine();

            //Pattern 7 - Palindrome Triangle Pattern
            Console.WriteLine("Pattern 7 - Palindrome Triangle Pattern");
            Console.WriteLine();
            Pattern7(n);
            Console.WriteLine();

            //Pattern 8 - Rhombus Pattern
            Console.WriteLine("Pattern 8 - Rhombus Pattern");
            Console.WriteLine();
            Pattern8(n);
            Console.WriteLine();

            //Pattern 9 - Diamond Star Pattern
            Console.WriteLine("Pattern 9 - Diamond Star Pattern");
            Console.WriteLine();
            Pattern9(n);
            Console.WriteLine();

            //Pattern 10 - Mirror Image Triangle Pattern
            Console.WriteLine("Pattern 10 - Mirror Image Triangle Pattern");
            Console.WriteLine();
            Pattern10(n);
            Console.WriteLine();

            //Pattern 11 - Hollow Triangle Pattern
            Console.WriteLine("Pattern 11 - Hollow Triangle Pattern");
            Console.WriteLine();
            Pattern11(n);
            Console.WriteLine();

            //Pattern 12 - Hollow Reverse Triangle Pattern
            Console.WriteLine("Pattern 12 - Hollow Reverse Triangle Pattern");
            Console.WriteLine();
            Pattern12(n);
            Console.WriteLine();

            //Pattern 13 - Hollow Diamond Pyramid
            Console.WriteLine("Pattern 13 - Hollow Diamond Pyramid");
            Console.WriteLine();
            Pattern13(n);
            Console.WriteLine();

            //Pattern 14 - Hollow Hourglass Pattern
            Console.WriteLine("Pattern 14 - Hollow Hourglass Pattern");
            Console.WriteLine();
            Pattern14(n);
            Console.WriteLine();


            //Pattern 15 - Pascal Triangle
            Console.WriteLine("Pattern 15 - Pascal Triangle");
            Console.WriteLine();
            Pattern15(n);
            Console.WriteLine();

        }

        static void Pattern1(int n)
        {

            // for  row
            for (int i = 1; i <= n; i++)
            {
                // for  column 
                for (int j = 1; j <= n; j++)
                {

                    if (i == 1 || i == n || j == 1 || j == n)
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

        static void Pattern2(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                // to print spaces
                for (int j = 1; j <= n - i; j++)
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

        static void Pattern3(int n)
        {
            
            //for rows
            for (int i = 1; i <= n; i++)
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


        static void Pattern4(int n)
        {
           

            //for rows
            for (int i = 0; i < n; i++)
            {
                //for columns 
                for (int j = n; j > i; j--)
                {
                    Console.Write(n - j + 1 + " ");
                }

                //next line 
                Console.WriteLine(" ");
            }
        }

        static void Pattern5(int n)
        {
           
            int n1 = 1;

            //for rows
            for (int i = 1; i <= n; i++)
            {
                //for columns
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n1 + " ");
                    n1 = n1 + 1;
                }

                //next line 
                Console.WriteLine(" ");
            }

        }

        static void Pattern6(int n)
        {
            int start = 1;
            
            //for rows
            for (int i = 0; i <= n; i++)
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

        static void Pattern7(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                // for spaces
                for (int j = 1; j <= n - i; j++)
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

        static void Pattern8(int n)
        {
            
            for (int i = 1; i <= n;  i++)
            {
                // for spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        static void Pattern9(int n)
        {

           

            //for erected pyramid

            // for the rows.
            for (int i = 0; i < n; i++)
            {
                //for spaces
                for (int j = 0; j < n - i - 1; j++)
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
            for (int i = 0; i < n; i++)
            {
                //for spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // printing the stars in each row
                for (int j = 0; j < 2 * n - (2 * i + 1); j++)
                {

                    Console.Write("*");
                }


                Console.WriteLine();
            }


        } 

        static void Pattern10(int n)
        {
            

            //for inverted pyramid
            //for rows
            for (int i = 0; i < n; i++)
            {
                //for spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // printing increasing number
                for (int j = i+1; j <=n; j++)
                {

                    Console.Write(j+" ");
                }


                Console.WriteLine();
            }

            //for erected pyramid

            // for the rows.
            for (int i = 1; i < n; i++)
            {
                //for spaces
                for (int j = 1; j < n - i ; j++)
                {
                    Console.Write(" ");
                }

                //  printing the increasing number 
                for (int j = n - i; j <=  n; j++)
                {

                    Console.Write(j+" ");
                }

                //next line
                Console.WriteLine(" ");

            }

        }

        static void Pattern11(int n )
        {
            
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


        static void Pattern12(int n)
        {
            
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

        static void Pattern13(int n)
        {
            
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

        static void Pattern14(int n)
        {
            
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



        static void Pattern15(int n)
        {
            
            for(int i = 1; i<=n; i++)
            {
                int b = 1;
                for(int j = 0; j <= n -i; j++)
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
