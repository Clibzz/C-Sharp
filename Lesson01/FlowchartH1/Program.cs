namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get the factorial: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factorial of " + j + " = "+ Factorial(j));
        }
        public static int Factorial(int n)
        {
            if (n <= 1) 
            { 
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}

