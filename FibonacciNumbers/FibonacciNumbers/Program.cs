using System;
using System.Numerics;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger output = Fibonacci(100);
            Console.WriteLine("output::" + output);
            Console.ReadLine();
        }

        //This function returns the value of the fibonacci series for a index passed as a parameter
        /*I have used dynamic programming to solve this problem instead of recursion because recursion time complexity is 
        exponential but this method has more space complexity as compared to recursion.
        If we want the time complexity to be less than we should use dynamic programming and if we want the space 
        complexity to be low then we should use Recursion*/
        private static BigInteger Fibonacci(int index)
        {
            //used BigInteger to hold large values
            BigInteger[] fib = new BigInteger[index + 1];
            int i;

            //initialize the first two elements of fibonacci
            fib[0] = 0;
            fib[1] = 1;

            //run for loop until index to calculate fibonacci and store it in the array
            for (i = 2; i <= index; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            //return output
            return fib[index];
        }
    }
}
