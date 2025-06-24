using System;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida");
            Console.WriteLine("2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo");
            Console.WriteLine("3. Crie um programa com 2 valores do tipo double já declarados que retorne:");
            Console.WriteLine("4. Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem");
            Console.WriteLine("5. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018");
            Console.WriteLine("6. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Welcome();
                    break;
                case 2:
                    SayYourName();
                    break;
                case 3:
                    Math();
                    break;
                case 4:
                    CountCharacters();
                    break;
                case 5:
                    VerifyLicensePlate();
                    break;
                case 6:
                    ShowDate();
                    break;
                case 0:
                    Console.WriteLine("Finaliza.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }

    static void Welcome()
    {
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    static void SayYourName()
    {
        Console.Write("Qual o seu nome? ");
        string name = Console.ReadLine();
        Console.Write("E o seu sobrenome? ");
        string lastname = Console.ReadLine();
        Console.WriteLine("Olá," + name + " " + lastname + "!");
    }

    static void Math()
    {
        Console.Write("Digite um número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Soma: " + (num1 + num2));
        Console.WriteLine("Subtração: " + (num1 - num2));
        Console.WriteLine("Multiplicação: " + (num1 * num2));

        if (num2 != 0)
            Console.WriteLine("Divisão: " + (num1 / num2));
        else
            Console.WriteLine("Divisão: Não é possível dividir por zero.");

        Console.WriteLine("Média: " + ((num1 + num2) / 2));
    }

    static void CountCharacters()
    {
        Console.Write("Digite uma ou mais palavras: ");
        string x = Console.ReadLine();

        int counter = 0;

        foreach (char c in x)
        {
            if (c != ' ')
                counter++;
        }

        Console.WriteLine("Quantidade de caracteres: " + counter);
    }

    static void VerifyLicensePlate()
    {
        Console.Write("Digite a placa do veículo para verificar se ela é válida ou não: ");
        string licensePlate = Console.ReadLine();

        bool isValid = Regex.IsMatch(licensePlate, @"^[a-zA-Z]{3}[0-9]{4}$");

        Console.WriteLine(isValid ? "Verdadeiro" : "Falso");
    }

    static void ShowDate()
    {
        DateTime agora = DateTime.Now;
        CultureInfo cultura = new CultureInfo("pt-BR");

        Console.WriteLine("Formato completo:");
        Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", cultura));

        Console.WriteLine("\nApenas a data:");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));

        Console.WriteLine("\nApenas a hora:");
        Console.WriteLine(agora.ToString("HH:mm:ss"));

        Console.WriteLine("\nData com mês por extenso:");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", cultura));
    }
}
