namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }
        public static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\chris\OneDrive\Bureaublad\C# Projects\Lesson01\HandlingExceptions/data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}