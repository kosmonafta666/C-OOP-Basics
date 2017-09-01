namespace Fibonacci_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fibonacci
    {
        public static long[] fibonacciNumbers;

        public Fibonacci()
        {
            fibonacciNumbers = new long[102];

            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;
            fibonacciNumbers[2] = 1;

            Fib();
        }

        private long Fib(int number = 100)
        {
            if (fibonacciNumbers[number] == 0)
            {
                fibonacciNumbers[number] = Fib(number - 1) + Fib(number - 2);
            }

            return fibonacciNumbers[number];
        }

        public long GetFibonacci(int number)
        {
            return fibonacciNumbers[number];
        }

        public List<long> FibonacciRange (int startPosition, int endPosition)
        {
            var resultList = new List<long>();

            for (int i = startPosition; i < endPosition; i++)
            {
                resultList.Add(fibonacciNumbers[i]);
            }

            return resultList;
        }
    }

    public class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            //read the start range;
            var startRange = int.Parse(Console.ReadLine());

            //var for end range;
            var endRange = int.Parse(Console.ReadLine());

            //var for fibonacci object;
            var fibonacci = new Fibonacci();

            //list for result;
            var result = fibonacci.FibonacciRange(startRange, endRange);

            //print the result;
            Console.WriteLine("{0}", string.Join(", ", result));
        }
    }
}
