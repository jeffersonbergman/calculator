using Calculator.Models;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

Operation calc = new Operation();

string opcao;
bool exibirMenu = true;
Console.WriteLine("Seja bem vindo a minha calculadora, aqui você pode escolher a operação que deseja fazer, digitando abaixo uma das opções.");

    while (exibirMenu)
        {
            
            Console.WriteLine("Escolha um opção de operação.");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Encerrar");

    //Criar o meu menu, usando o switch, se a "opcao" que é igual ao valor que irei receber, for um dos casos abaixo, vai retornar o objeto de operação.
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    return calc.sum();
                    
                break;              

                case "2":
                    return calc.subtraction();

                break;

                case "3":
                    return calc.multiplication();

                break;

                case "4":
                    return calc.division();

                break;

                case "5":
                    return calc.percentage();

                break;

                case "6":
                    Console.WriteLine("Encerrar.");
                    Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("Opção Inválida.");
                break;
            }
        }