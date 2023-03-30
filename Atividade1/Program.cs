using Atividades;
using System.Globalization;

// Aluno: Gabriel de Oliveira Silva

bool loop = true;

do
{
    Console.WriteLine($"Selecione a atividade");
    Console.WriteLine($"Digite o número correspondente");

    for (int i = 1; i <= 8; i++)
    {
        Console.WriteLine($"Atividade {i}");

    }

    string choice = Console.ReadLine() ?? "0";

    Console.Clear();

    switch (choice)
    {
        case "1":
            App.Atividade1();
            break;
        case "2":
            App.Atividade2();
            break;
        case "3":
            App.Atividade3();
            break;
        case "4":
            App.Atividade4();
            break;
        case "5":
            App.Atividade5();
            break;
        case "6":
            App.Atividade6();
            break;
        case "7":
            App.Atividade7();
            break;
        case "8":
            App.Atividade8();
            break;
        default:
            loop = !loop;
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (loop);

namespace Atividades
{
    public static class App
    {
        public static void Atividade1()
        {

            double[] numbers = new double[4];

            Console.WriteLine($"Soma de 4 numeros");


            for (int i = 1; i <= numbers.Length; i++)
            {
                Console.WriteLine($"Insira o {i}º número, (casas decimais com \".\")");
                numbers[i - 1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"A soma é igual a: {Soma(numbers).ToString("F2", CultureInfo.InvariantCulture)}");

        }
        public static void Atividade2()
        {
            double[] numbers = new double[3];

            Console.WriteLine($"Média de 3 números");


            for (int i = 1; i <= numbers.Length; i++)
            {
                Console.WriteLine($"Insira o {i}º número, (casas decimais com \".\")");
                numbers[i - 1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"A média dos valores informados é: {Media(numbers).ToString("F2", CultureInfo.InvariantCulture)}");

        }
        public static void Atividade3()
        {
            Console.WriteLine($"Insira o nome do produto");
            string produto = Console.ReadLine();

            Console.WriteLine($"Insira o código do produto");
            string cod = Console.ReadLine();

            Console.WriteLine($"Insira o valor do produto (casas decimais com \".\")");
            double valUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Insira a quantidade de produtos");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"O produto de código: {cod} e nome: {produto}, foi vendido!");


            Console.WriteLine($"No total, foram vendidas: {quantidade} unidades à R${valUnitario.ToString("F2", CultureInfo.InvariantCulture)} cada, totalizando {(quantidade * valUnitario).ToString("F2", CultureInfo.InvariantCulture)}");

        }
        public static void Atividade4()
        {
            double reajuste = 8.75 / 100;

            Console.WriteLine($"Insira o nome do Funcionário");
            string funcionario = Console.ReadLine();

            Console.WriteLine($"Insira o salário atual do funcionário, (Casas decimais com \".\")");
            double salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioReajustado = (salarioAtual * reajuste) + salarioAtual;

            Console.WriteLine($"O funcionário {funcionario}, receberá um aumento de {(reajuste * 100).ToString("F2", CultureInfo.InvariantCulture)}%");

            Console.WriteLine($"O salário sairá de {salarioAtual.ToString("F2", CultureInfo.InvariantCulture)}, para {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void Atividade5()
        {
            double desconto = 10.0 / 100.0;

            Console.WriteLine($"Insira o nome do produto");
            string produto = Console.ReadLine();

            Console.WriteLine($"Insira o valor do produto (casas decimais com \".\")");
            double valInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valFinal = valInicial - (valInicial * desconto);

            Console.WriteLine($"O produto: {produto}, receberá um desconto de {(desconto * 100)}%");

            Console.WriteLine($"O valor sairá de R${valInicial.ToString("F2", CultureInfo.InvariantCulture)}, para R${valFinal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
        public static void Atividade6()
        {
            Console.WriteLine($"Insira um número para verificar se ele é par");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string resultado = number % 2 == 0 ? "par" : "ímpar";

            Console.WriteLine($"O número: {number.ToString("F2", CultureInfo.InvariantCulture)} é {resultado}");
        }
        public static void Atividade7()
        {
            Console.WriteLine($"Insira um número para verificar se ele é par");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number == 0)
            {
                Console.WriteLine($"O número é zero (nem par nem ímpar)");
            }
            else
            {
                string resultado = number % 2 == 0 ? "par" : "ímpar";
                Console.WriteLine($"O número: {number.ToString("F2", CultureInfo.InvariantCulture)} é {resultado}");
            }
        }
        public static void Atividade8()
        {
            Console.WriteLine($"Insira um número para verificar se ele é múltiplo de 3 ou 7");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<double> dividers = new List<double>();

            if (!(number % 7 == 0 || number % 3 == 0))
            {
                Console.WriteLine($"O número não é divisível nem por 3 nem por 7");
            }
            else
            {

                if (number % 3 == 0)
                {
                    dividers.Add(3);
                }
                if (number % 7 == 0)
                {
                    dividers.Add(7);
                }


                Console.WriteLine($"O número é divisível por: {String.Join(" e ", dividers)}");
            }
        }


        // utilitarios

        public static double Soma(double[] numbers)
        {
            double amount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                amount += numbers[i];
            }
            return amount;
        }

        public static double Media(double[] numbers)
        {
            return Soma(numbers) / numbers.Length;
        }
    }
}