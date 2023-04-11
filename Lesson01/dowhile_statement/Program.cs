namespace Lesson01 {
    class Program {
        static void Main(string[] args) {
            DoWhileTest();
        }
        public static void DoWhileTest() {
            int i = 1;
            do {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
        }
    }
}