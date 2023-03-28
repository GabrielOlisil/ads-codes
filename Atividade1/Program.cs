using Atividades;

Console.WriteLine($"Selecione a atividade");
Console.WriteLine($"DIgite o número correspondente");

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine($"Atividade {i}, pressione {i}");

}

string choice = Console.ReadLine() ?? "0";


switch (choice)
{
    case "1":
        App.Atividade1();
        break;
    case "2":
        break;
    default:
        System.Environment.Exit(0);
        break;
}

Console.ReadKey();






namespace Atividades
{


    public static class App
    {
        // Atividade 1
        public static void Atividade1()
        {

            long[] numbers = new long[4];
            double soma = 0.0;

            Console.Clear();


            for (int i = 1; i <= numbers.Length; i++)
            {
                Console.WriteLine($"Insira o {i}º número");
                numbers[i - 1] = long.Parse(Console.ReadLine());
            }



            for (int i = 0; i < numbers.Length; i++)
            {
                soma += numbers[i];

            }
            Console.WriteLine($"A soma é igual a: {soma}");

        }
        public static void Atividade2()
        {

        }
    }

}