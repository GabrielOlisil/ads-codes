using Loop.Atividades.Entities;

namespace Loop.Atividades;

static class Atv5_6
{
    public static void Atividade11()
    {
        double number = 0;
        int counter = 0;
        uint between0And25_9 = 0;
        uint between26And50_9 = 0;
        uint between51And75_9 = 0;
        uint between76And100 = 0;
        do
        {
            counter++;

            Console.Write($"Insira o {counter}º número: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number is >= 0 and <= 25.9)
            {
                between0And25_9++;
            }
            else if (number <= 50.9)
            {
                between26And50_9++;
            }
            else if (number <= 75.9)
            {
                between51And75_9++;
            }
            else if (number <= 100)
            {
                between76And100++;
            }
        } while (number > 0);

        Console.Clear();

        Console.WriteLine($"Numeros nos intervalos:");
        Console.WriteLine($"[0, 25.9]: {between0And25_9}");
        Console.WriteLine($"[26, 50.9]: {between26And50_9}");
        Console.WriteLine($"[51, 75.9]: {between51And75_9}");
        Console.WriteLine($"[76, 100]: {between76And100}");

        Console.ReadKey();
    }

    public static void Atividade12()
    {
        var wantAddMore = false;
        uint count = 0;
        uint hasBlondeHairAndGreenEyes = 0;
        uint totalAge = 0;
        double totalHeight = 0, totalWeight = 0;
        double averageAge = 0, averageHeight = 0, averageWeight = 0;
        uint totalMan = 0, totalWoman = 0;

        do
        {
            count++;
            Console.WriteLine("Sexo do participante");
            Console.WriteLine("Masculino = 1");
            Console.WriteLine("Feminino = 2");
            var sex = Enum.Parse<Sex>(Console.ReadLine() ?? "1");


            Console.WriteLine("Cor do cabelo participante");
            Console.WriteLine("Louro = 1");
            Console.WriteLine("Castanho = 2");
            Console.WriteLine("Preto = 3");
            var hairColor = Enum.Parse<HairColor>(Console.ReadLine() ?? "1");


            Console.WriteLine("Cor do olho participante");
            Console.WriteLine("Azul = 1");
            Console.WriteLine("Verde = 2");
            Console.WriteLine("Castanho = 3");
            var eyeColor = Enum.Parse<EyeColor>(Console.ReadLine() ?? "1");


            Console.WriteLine($"Idade do Participante");
            var age = Convert.ToByte(Console.ReadLine());

            totalAge += age;

            Console.WriteLine($"Altura (cm) do Participante");
            var height = Convert.ToDouble(Console.ReadLine());

            totalHeight += height;


            Console.WriteLine($"Weight (kg) do Participante");
            var weight = Convert.ToDouble(Console.ReadLine());

            totalWeight += weight;

            if (sex is Sex.Fem)
            {
                totalWoman++;
            }
            else
            {
                totalMan++;
            }


            if (eyeColor is EyeColor.Verde && hairColor is HairColor.Louro)
            {
                hasBlondeHairAndGreenEyes++;
            }

            Console.Write("Deseja adicionar mais participantes [S/n]: ");
            var opt = Console.ReadLine();

            wantAddMore = opt?.ToLower() == "s";
        } while (wantAddMore);

        averageAge = (double)totalAge / count;
        averageHeight = totalHeight / count;
        averageWeight = totalWeight / count;


        Console.WriteLine($"Média de idade dos participantes: {averageAge}");
        Console.WriteLine($"Média de altura dos participantes: {averageHeight}");
        Console.WriteLine($"Média de peso dos participantes: {averageWeight}");
        Console.WriteLine(
            $"Percentagem de Homens: {((double)totalMan / count).ToString("P2", CultureInfo.InvariantCulture)}");
        Console.WriteLine(
            $"Percentagem de Homens: {((double)totalWoman / count).ToString("P2", CultureInfo.InvariantCulture)}");
        Console.WriteLine(
            $"Quantidade de Pessoas que possuem olhos verdes e cabelos louros: {hasBlondeHairAndGreenEyes}");
        Console.ReadKey();
    }


    public static void Atividade13()
    {
        Console.WriteLine("Insira o Numero");
        var number = Convert.ToUInt32(Console.ReadLine());

        var fatorial = 1.0;

        if (number == 0)
        {
            Console.WriteLine($"O fatorial de {number} é 1");
            Console.ReadKey();

            return;
        }

        for (var i = number; i > 0; i--)
        {
            fatorial *= i;
        }

        Console.WriteLine($"O fatorial de {number} é {fatorial}");

        Console.ReadKey();
    }

    public static void Atividade14()
    {
        Console.WriteLine("Insira o Numero");
        var number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira a Potencia");
        var pow = Convert.ToUInt32(Console.ReadLine());

        int baseNumber = number;

        for (int i = 1; i < pow; i++)
        {
            number *= baseNumber;
        }

        Console.WriteLine(number);

        Console.ReadKey();

    }

    public static void Atividade16()
    {
        Console.WriteLine("Insira o Numero");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number is 1 or 0)
        {
            Console.WriteLine("Não é primo");
            Console.ReadKey();
            return;
        }

        if (number == 2)
        {
            Console.WriteLine("É primo");
            Console.ReadKey();

            return;
        }

        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("Não é Primo");
                Console.ReadKey();

                return;
            }
        }

        Console.WriteLine("é primo");

        Console.ReadKey();

    }

    public static void Atividade17()
    {
        Console.WriteLine($"Insira O primeiro número");
        var n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Insira O segundo número");
        var n2 = Convert.ToInt32(Console.ReadLine());


        (int, int) mdc = (n1, n2);

        if (mdc.Item1 < mdc.Item2)
        {
            mdc = (mdc.Item2, mdc.Item1);
        }

        while (mdc.Item1 > 0 && mdc.Item2 > 0)
        {
            mdc = (mdc.Item2, mdc.Item1 % mdc.Item2);
        }


        Console.WriteLine($"O mdc de ({n1}, {n2}) é {mdc.Item1}");
        Console.ReadKey();


    }


    public static void Atividade18()
    {
        Console.WriteLine($"Insira o número inicial");
        var inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Insira o número inicial");
        var final = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine($"Os números perfeitos são:");

        for (var i = inicio; i <= final; i++)
        {
            var sumDividers = 0.0;

            for (var j = 1; j <= (i / 2); j++)
            {
                if (i % j == 0)
                {
                    sumDividers += j;

                }
            }


            if (sumDividers == i)
            {
                Console.WriteLine($"{i}");
            }
        }

        Console.ReadKey();

    }

    public static void Atividade19()
    {
        Console.WriteLine($"insira a distancia em Km");
        var distancia = Convert.ToDouble(Console.ReadLine());

        double positionA = 0.0, positionB = distancia;
        const double R_MOVEMENT_A = 80;
        const double R_MOVEMENT_B = 100;

        var minutes = 0;

        while (positionA <= positionB)
        {
            positionA += (R_MOVEMENT_A / 60);
            positionB -= (R_MOVEMENT_B / 60);
            minutes++;
        }

        Console.WriteLine($"Foram necessários {minutes} minutos");

        Console.ReadKey();


    }

    public static void Atividade20()
    {
        double somaTotal = 0;
        double mediaGeral = 0.0;
        char conceitoGeral = 'E';

        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine($"Insira a nota do {i}º aluno");
            var nota = Convert.ToDouble(Console.ReadLine());

            somaTotal += nota;

            mediaGeral = somaTotal / i;

            char conceito = 'E';

            if (nota is >= 0 and <= 2.9)
            {
                conceito = 'E';
            }
            else if (nota <= 4.9)
            {
                conceito = 'D';
            }
            else if (nota <= 6.9)
            {
                conceito = 'C';
            }
            else if (nota <= 8.9)
            {
                conceito = 'B';
            }
            else if (nota <= 10)
            {
                conceito = 'A';
            }


            Console.WriteLine($"O conceito do aluno {i} foi: {conceito}");


        }

        if (mediaGeral is >= 0 and <= 2.9)
        {
            conceitoGeral = 'E';
        }
        else if (mediaGeral <= 4.9)
        {
            conceitoGeral = 'D';
        }
        else if (mediaGeral <= 6.9)
        {
            conceitoGeral = 'C';
        }
        else if (mediaGeral <= 8.9)
        {
            conceitoGeral = 'B';
        }
        else if (mediaGeral <= 10)
        {
            conceitoGeral = 'A';
        }



        Console.WriteLine($"A média geral da sala ficou: {mediaGeral.ToString("F2", CultureInfo.InvariantCulture)}, a sala obteve conceito: {conceitoGeral}");

        Console.ReadKey();


    }


}