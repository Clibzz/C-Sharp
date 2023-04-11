namespace Lesson01 {
    class Program {
        static void Main(string[] args) {
            ForTest();
        }
        public static void ForTest() {
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("The value of i = {0}", i);
            }
        }
    }
}