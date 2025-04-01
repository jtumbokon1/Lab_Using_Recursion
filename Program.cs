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

        //	One that prints out how many times a number entered by the user can be evenly divided by 2.
        public static int DivisibleByTwo(int n)
        {
            if (n % 2 == 0)
            {
                return DivisibleByTwo(n / 2);
            }
            else
            {
                return n;
            }
        }
    }
}
