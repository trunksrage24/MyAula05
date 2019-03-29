using System;

namespace MyFirstMethod
{
    class Program
    {
        static void CountTo10()
        {
            CountToN(10);
        }
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            CountToN(4);
            CountToN(8);
        }
    }
}
