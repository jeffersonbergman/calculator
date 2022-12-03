using Calculator.Models;

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

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite aqui o primeiro número para a soma");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite aqui o segundo número para a soma");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x} + {y} = {x + y}");

                    break;

                case "2":
                    Console.WriteLine("Digite aqui o primeiro número para a subtração");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite aqui o segundo número para a subtração");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x} - {y} = {x - y}");

                    break;
                case "3":
                    Console.WriteLine("Digite aqui o primeiro número para a multiplicação");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite aqui o segundo número para a multiplicação");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x} x {y} = {x * y}");

                    break;
                case "4":
                    Console.WriteLine("Digite aqui o primeiro número para a divisão");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite aqui o segundo número para a divisão");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x} / {y} = {x / y}");

                    break;

                case "5":
                    Console.WriteLine("Digite aqui o primeiro número para a porcentagem");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite aqui o segundo número para a porcentagem");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x} % {y} = {x % y}");

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