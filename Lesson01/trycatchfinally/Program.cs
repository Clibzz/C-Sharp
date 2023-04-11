namespace Lesson01 {
    class Program {
        static void Main(string[] args) {
            TryCatchFinallyTest();
        }
        public static void TryCatchFinallyTest() {
            StreamReader sr = null;
            try {
                sr = File.OpenText(@"C:\Users\chris\OneDrive\Bureaublad/data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe) {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null) {
                    sr.Close();
                }
            }
        }
    }
}