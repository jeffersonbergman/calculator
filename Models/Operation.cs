using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Operation
    {
        //Cada metodo com sua funcionalidade, e está sendo chamada pelo case do menu.
        public void sum(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro número para a soma");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo número para a soma");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void subtraction(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro número para a subtração");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo número para a subtração");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void multiplication(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro número para a multiplicação");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo número para a multiplicação");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void division(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro número para a divisão");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo número para a divisão");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void percentage(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro número para a porcentagem");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo número para a porcentagem");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

    }
}