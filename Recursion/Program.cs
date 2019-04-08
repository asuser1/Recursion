using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = 0;

            if (int.TryParse(s, out i))
            {
                Console.WriteLine("Factorial: " + fact(i));
                Console.WriteLine("Fibronacci: " + fib(i, new int[i + 1]));
            }


            Console.ReadLine();
        }

        static int fact(int n)
        {
            if (n <= 0)
                return 1;

            return n * fact(n - 1);
        }

        static int fib(int n)
        {
            if (n <= 0)
                return 0;

            if (n == 2 || n == 1)
                return 1;

            return fib(n - 1) + fib(n - 2);
        }

        //Dynamic programming
        static int fib(int n, int[] m)
        {
            if (m[n] != 0)
                return m[n];

            if (n == 2 || n == 1)
            {
                m[n] = 1;
                return 1;
            }

            int result = fib(n - 1, m) + fib(n - 2, m);

            m[n] = result;

            return result;
        }
    }
}
