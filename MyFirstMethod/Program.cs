using System;

namespace MyFirstMethod
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// method that changes function to CountToN(10)
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }
        /// <summary>
        /// method that counts numbers from one to n; n being a designated number
        /// </summary>
        /// <param name="n">n is a number that changes each time it is printed</param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
        /// <summary>
        /// print the numbers from the previous methods twice for each method
        /// </summary>
        /// <param name="args">main does not return anything</param>
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            CountToN(4);
            CountToN(8);
        }
    }
}
