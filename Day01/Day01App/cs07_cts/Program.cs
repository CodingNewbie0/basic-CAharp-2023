using System;

namespace cs07_cts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Int32 a = 12345; //CTS
            int b = 12345;

            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);

            System.String d = "abcdef"; //CTS
            string e = "abcdef";
            Console.WriteLine(d.GetType());
            Console.WriteLine(e.GetType());

        }
    }
}
