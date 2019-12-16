using System;
using System.Numerics;
using System.Threading;
using static System.Console;
using static System.Convert;

namespace PassingFuncsAsParams
{
    class Program
    {
        private static void DoSomething()
        {
            WriteLine("Doing something...");
            Thread.Sleep(5000);
        }

        private static BigInteger Silnia(int l)
        {
            BigInteger w;

            for (BigInteger i = 1; i <= l; i++)
            {
                w *= i;
            }
            return w;
        }

        private static void DoingSomethingMore(Action ac)
        {
            DoSomething();
        }

        private static void SilniaZWynikiem(Func<int, BigInteger> ac, int n)
        {
            WriteLine(Silnia(n));
        }

        static void Main(string[] args)
        {
            //DoingSomethingMore(DoSomething);
            SilniaZWynikiem(Silnia, 10000);
        }
    }
}
