using System;

namespace AnotherBlockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            { // int x;//사용시 오류
                int y = 2;
                Console.WriteLine("Block 1: x = " + x + ", y = " + y);
            }
            {
                int y = 3;
                Console.WriteLine("Block 2: x = " + x + ", y = " + y);
            }
            }
    }
}
