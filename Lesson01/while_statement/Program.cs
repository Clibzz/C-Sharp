﻿namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
        }
        public static void WhileTest()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
        }
    }
}

