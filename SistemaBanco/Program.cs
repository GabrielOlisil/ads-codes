using System;


namespace SistemaBanco;

internal class Program
{
    static void Main(string[] args)
    {
        /* string nomePessoa;
        float saldo = 1450.0f;
        int valorSaque = 0;

        Console.WriteLine("Digite seu nome: ");
        nomePessoa = Console.ReadLine() ?? "";


        Console.WriteLine("Digite o valor do saque");
        valorSaque = int.Parse(Console.ReadLine());

        bool verificacao = (saldo > valorSaque);
        saldo = verificacao ? saldo - valorSaque : saldo;

        Console.WriteLine($"Seu saldo {((verificacao) ? "" : "não")} foi aprovado");

        Console.WriteLine($"Seu saldo é: {saldo}");
        Console.ReadKey(); */

        Console.WriteLine("Insira o primeiro Número");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o segundo Número");
        int numero2 = int.Parse(Console.ReadLine());


        Console.WriteLine($"A soma de {numero1} + {numero2} é: {numero1 + numero2}");

    }
}
