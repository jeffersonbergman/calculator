using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Operation
    {
        //Cada metodo com sua funcionalidade, e est� sendo chamada pelo case do menu.
        public void sum(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro n�mero para a soma");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo n�mero para a soma");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void subtraction(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro n�mero para a subtra��o");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo n�mero para a subtra��o");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void multiplication(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro n�mero para a multiplica��o");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo n�mero para a multiplica��o");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void division(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro n�mero para a divis�o");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo n�mero para a divis�o");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void percentage(float x, float y)
        {
            Console.WriteLine("Digite aqui o primeiro n�mero para a porcentagem");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite aqui o segundo n�mero para a porcentagem");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

    }
}