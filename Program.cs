/*
* Course: OOP2 CPRG-211-C
* Assignment: Lab Using Recursion
* Author: Jirch Tumbokon
* When: Winter 2025
* Purpose: To demonstrate the use of recursion in C# by
*          calculating the sum of all numbers from n to m, recursively and
*          printing out how many times a number can be evenly divided by 2.
*/

using System.Transactions;

namespace Lab_Using_Recursion
{
   internal class Program
   {
       static void Main(string[] args)
       {
           // Display the addition output
           Console.WriteLine("Addition");
           Console.WriteLine("Enter number n:");
           double n = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Enter number m:");
           double m = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine(Sum(n,m));

           // Display the division output
           Console.WriteLine("Division");
           Console.WriteLine("Enter your number:");
           int num = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine($"Total number of divisions: {DivisibleByTwo(num)}");
       }

       // Calculate the sum of all the numbers from n to m, recursively
       public static double Sum(double n, double m)
       {
           if (n == m)
           {
               return n;
           }
           else
           {
               return n + Sum(n + 1, m);
           }
       }

       // Count how many times a number can be evenly divided by 2
       public static int DivisibleByTwo(int n)
       {
           if (n % 2 != 0)
           {
               return 0;
           }
           else
           {
               return 1 + DivisibleByTwo(n / 2);
           }
       }
   }// class
}// namespace
