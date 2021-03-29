using System;

namespace ReadintegerApp
{
    class Program
    {
        static int ReadInt()
        {
            char ch;
            int n = 0;
            while (!char.IsDigit(ch = (char)Console.Read())) ;
            do
            {
                n =  (ch - '0');
                ch = (char)Console.Read();
            } while (char.IsDigit(ch));
            return n;
        }

        static void Main(string[] args)
        {
            {
                Console.Write("*** input data : ");
                Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
            }
        }
    }
}