namespace Vetores;

public class Atividades
{
    public static void Atividade2()
    {
        var temperaturas = new int[7];

        for (int i = 0; i < temperaturas.Length; i++)
        {
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine($"Insira a temperatura referente ao dia {i + 1}");

                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    isValidInput = true;
                    temperaturas[i] = number;
                }
                else
                {
                    Console.WriteLine("Insira um valor válido");
                }
            }
        }

        double soma = 0.0;

        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }

        var media = soma / temperaturas.Length;


        byte maioresQueAMedia = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > media) maioresQueAMedia++;
        }

        Console.WriteLine("valores: ");
        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.WriteLine(temperaturas[i].ToString("F2"));
        }

        Console.WriteLine();

        Console.WriteLine("Média: " + media.ToString("F2"));

        Console.WriteLine("Maiores que a média: " + maioresQueAMedia);


        Console.WriteLine("Seguindo para proximo exercício, aperte qualquer tecla");
        Console.ReadKey();
    }


    public static void Atividade3()
    {
        var vogais = new char[5];
        vogais[0] = 'a';
        vogais[1] = 'e';
        vogais[2] = 'i';
        vogais[3] = 'o';
        vogais[4] = 'u';


        var alturasEmMetros = new float[10];

        alturasEmMetros[0] = 1.20f;
        alturasEmMetros[1] = 1.45f;
        alturasEmMetros[2] = 1.50f;
        alturasEmMetros[3] = 1.70f;
        alturasEmMetros[4] = 1.90f;
        alturasEmMetros[5] = 1.34f;
        alturasEmMetros[6] = 1.85f;
        alturasEmMetros[7] = 1.76f;
        alturasEmMetros[8] = 1.65f;
        alturasEmMetros[9] = 1.20f;


        var mesesAno = new string[12];

        mesesAno[0] = "Janeiro";
        mesesAno[1] = "Fevereiro";
        mesesAno[2] = "Março";
        mesesAno[3] = "Abril";
        mesesAno[4] = "Maio";
        mesesAno[5] = "Junho";
        mesesAno[6] = "Julho";
        mesesAno[7] = "Agosto";
        mesesAno[8] = "Setembro";
        mesesAno[9] = "Outubro";
        mesesAno[10] = "Novembro";
        mesesAno[11] = "Dezembro";


        Console.WriteLine("Vogais");
        for (int i = 0; i < vogais.Length; i++)
        {
            Console.Write($"{vogais[i]} ");
        }

        Console.WriteLine();


        Console.WriteLine("alturas");
        for (int i = 0; i < alturasEmMetros.Length; i++)
        {
            Console.Write($"{alturasEmMetros[i].ToString("F2")} ");
        }

        Console.WriteLine();


        Console.WriteLine("meses");
        for (int i = 0; i < mesesAno.Length; i++)
        {
            Console.Write($"{mesesAno[i]} ");
        }

        Console.WriteLine("Seguindo para proximo exercício, aperte qualquer tecla");
        Console.ReadKey();
    }


    public static void Atividade7()
    {
        var temperaturas = new int[7];
        string[] diasDaSemana = { "D", "S", "T", "Q", "Q", "S", "S" };

        for (int i = 0; i < temperaturas.Length; i++)
        {
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine($"Insira a temperatura referente À {diasDaSemana[i]}");

                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    isValidInput = true;
                    temperaturas[i] = number;
                }
                else
                {
                    Console.WriteLine("Insira um valor válido");
                }
            }
        }


        for (int i = 0; i < diasDaSemana.Length; i++)
        {
            Console.Write($"{diasDaSemana[i]}: ");

            for (int j = 0; j < temperaturas[i]; j++)
            {
                Console.Write('\u25B0');
            }

            Console.WriteLine();
        }

        Console.WriteLine("Seguindo para proximo exercício, aperte qualquer tecla");
        Console.ReadKey();
    }

    public static void Atividade8()
    {
        var a = new[] { 12, 21, 43, 52, 12, 23, 12, 54, 23, 13 };
        var b = new[] { 39, 83, 45, 72, 62, 25, 13, 75, 67, 32 };
        var c = new int[10];

        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i] + b[b.Length - i - 1];
        }

        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine($"c{i} = {c[i]}");
        }

        Console.WriteLine("Seguindo para proximo exercício, aperte qualquer tecla");
        Console.ReadKey();
    }

    public static void Atividade9()
    {
        var a = new[] { 15, 21, 21, 52, 12, 12, 43, 53, 62, 32 };
        var b = new[] { 15, 83, 15, 72, 12, 12, 32, 43, 52, 52 };
        int tamanhoC = 0;

        // Eu entendi por união levando ao pé da letra, removendo redundância de valores

        var temporario = new int?[20];

        for (int i = 0; i < a.Length; i++)
        {
            temporario[i] = a[i];
            temporario[a.Length + i] = b[i];
        }
        
        for (int i = 0; i < temporario.Length; i++)
        {
            for (int j = 0; j < temporario.Length; j++)
            {
                if (temporario[i] is null)
                {
                    continue;
                }

                if (i != j)
                {
                    if (temporario[i] == temporario[j])
                    {
                        temporario[j] = null;
                    }
                }
            }
        }


        for (int i = 0; i < temporario.Length; i++)
        {
            if (temporario[i] is not null)
            {
                tamanhoC++;
            }
        }


        var c = new int?[tamanhoC];
        int indexAPreencher = 0;

        for (int i = 0; i < temporario.Length; i++)
        {
            if (temporario[i] is not null)
            {
                c[indexAPreencher] = temporario[i];
                indexAPreencher++;
            }
        }

        Array.Sort(c);
        // Como eu queria ter usado SortedSet
        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine(c[i]);
        }

        Console.ReadKey();
    }
}