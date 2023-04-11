namespace Lesson01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The length of this number is " + Recursive(number));

        }
        public static int Recursive(int n) {
            int intLen = n.ToString().Length;
            return intLen;
        }
    }
}

