using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciProblem
{
    class Fibonacci
    {


        public Fibonacci(int ceiling)
        {
            int a;
            int b;
            int c;

            for (b = 1, c = 0; c <= ceiling; c = a + b)
            {
                a = b;
                b = c;
                Console.Write(b + ",");
            }
        }

    }
}
