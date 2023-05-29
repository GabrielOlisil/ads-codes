using static Loop.Atividades.Atv5_5;
using static Loop.Atividades.Atv5_6;

while (true)
{
    Console.Clear();
    Console.WriteLine("=================");
    Console.WriteLine("Hub de atividades");
    Console.WriteLine($"================={Environment.NewLine}");

    Console.WriteLine($"========================");
    Console.WriteLine($"Atividades Capitulo 5.5");
    Console.WriteLine($"========================{Environment.NewLine}");

    Console.WriteLine("Atividade 2 = 2");
    Console.WriteLine("Atividade 3 = 3");
    Console.WriteLine("Atividade 4 = 4");
    Console.WriteLine("Atividade 5 = 5");
    Console.WriteLine("Atividade 6 = 6");
    Console.WriteLine("Atividade 7 = 7");
    Console.WriteLine("Atividade 9 = 9");
    Console.WriteLine("Atividade 10 = 10");

    Console.WriteLine($"{Environment.NewLine}=======================");
    Console.WriteLine($"atividades Capitulo 5.6");
    Console.WriteLine($"======================={Environment.NewLine}");

    Console.WriteLine("Atividade 1 = 11");
    Console.WriteLine("Atividade 2 = 12");
    Console.WriteLine("Atividade 3 = 13");
    Console.WriteLine("Atividade 4 = 14");
    Console.WriteLine("Atividade 6 = 16");
    Console.WriteLine("Atividade 7 = 17");
    Console.WriteLine("Atividade 8 = 18");
    Console.WriteLine("Atividade 9 = 19");
    Console.WriteLine($"Atividade 10 = 20{Environment.NewLine}");
    Console.WriteLine($"================={Environment.NewLine}");

    Console.WriteLine("Sair = 0");
    Console.Write("Selecione a opção: ");
    var opt = Console.ReadLine();
    Console.Clear();


    switch (opt)
    {
        // Atividades do capitulo 5.5

        case "2":
            Atividade2();
            break;

        case "3":
            Atividade3();
            break;

        case "4":
            Atividade4();
            break;

        case "5":
            Atividade5();
            break;

        case "6":
            Atividade6();
            break;

        case "7":
            Atividade7();
            break;

        case "9":
            Atividade9();
            break;

        case "10":
            Atividade10();
            break;

        // Atividades do capitulo 5.6

        case "11":
            Atividade11();
            break;

        case "12":
            Atividade12();
            break;

        case "13":
            Atividade13();
            break;

        case "14":
            Atividade14();
            break;
        case "16":
            Atividade16();
            break;
        case "17":
            Atividade17();
            break;
        case "18":
            Atividade18();
            break;
        case "19":
            Atividade19();
            break;
        case "20":
            Atividade20();
            break;


        case "0":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Informe um valor válido");
            break;
    }
}
