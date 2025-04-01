using System.Transactions;

namespace Lab_Using_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number m:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sum(n,m));

            Console.WriteLine("Division");
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total number of divisions: {DivisibleByTwo(num)}");
        }

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
    }
}
