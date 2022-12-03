using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Operation
    {
        public void sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void subtraction(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void multiplication(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void division(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void percentage(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

        internal void sum()
        {
            throw new NotImplementedException();
        }
    }
}