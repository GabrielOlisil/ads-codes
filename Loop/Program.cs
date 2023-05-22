using static Loop.Atividades.Atv;


while (true)
{
    Console.Clear();
    Console.WriteLine("=================");
    Console.WriteLine("Hub de atividades");
    Console.WriteLine("=================\n");
    Console.WriteLine("Atividade 2 = 2");
    Console.WriteLine("Sair = 0");
    Console.Write("Selecione a opção: ");
    var opt = Console.ReadLine();
    Console.Clear();

    
    switch (opt)
    {
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
        
        
        case "0":
            Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("Informe um valor válido");
            break;
    }
}