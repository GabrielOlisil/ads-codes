using Loop.Atividades.Entities;

namespace Loop.Atividades;

static class Atv
{
    public static void Atividade2()
    {
        //converti pra uint por causa das casas decimais
        uint heightPedro = (uint)(1.50 * 100), heightLucas = (uint)(1.10 * 100);


        ushort years = 0;
        while (heightLucas <= heightPedro)
        {
            heightLucas += 3;
            heightPedro += 2;
            years++;


            if (heightLucas != heightPedro) continue;

            Console.WriteLine(
                $"A) Lucas: {((double)heightLucas / 100).ToString("F2", CultureInfo.InvariantCulture)} m, Pedro: {((double)heightPedro / 100).ToString("F2", CultureInfo.InvariantCulture)} m, as idades se igualaram ao passar de: {years} anos");
            Console.WriteLine($"B) Lucas será maior que pedro ao passar de {years + 1} anos");
        }

        Console.ReadKey();
    }

    public static void Atividade3()
    {
        Console.WriteLine("Insira até que número deseja efetuar a tabuada");
        var number = Convert.ToUInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"Tabuada do {i}");
            Console.WriteLine("=================================");

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {j * i}");
            }

            Console.WriteLine("=================================");
        }

        Console.ReadKey();
    }

    public static void Atividade4()
    {
        Console.WriteLine("Insira o menor valor");
        var menorValor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira o maior valor");
        var maiorValor = Convert.ToInt32(Console.ReadLine());

        int positivos = 0;
        int pares = 0;
        int impares = 0;
        int divisiveisPor3E7 = 0;
        int soma = 0;
        int totalIteracoes = 0;


        for (int i = menorValor; i <= maiorValor; i++)
        {
            if (i > 0)
            {
                positivos++;
            }

            if (i % 2 == 0 && i != 0)
            {
                pares++;
            }
            else
            {
                if (i != 0) impares++;
            }


            if (i % 3 == 0 && i % 7 == 0 && i != 0)
            {
                divisiveisPor3E7++;
            }

            soma += i;
            totalIteracoes++;
        }

        Console.WriteLine($"Numeros positivos: {positivos}");
        Console.WriteLine($"Numeros pares: {pares}");
        Console.WriteLine($"Numeros impares: {impares}");
        Console.WriteLine($"Numeros divisiveis por 3 e por 7: {divisiveisPor3E7}");
        Console.WriteLine($"média: {((double)soma / totalIteracoes).ToString("F2", CultureInfo.InvariantCulture)}");
    }

    public static void Atividade5()
    {
        Console.WriteLine("Digite o enésimo termo da fibonacci");
        var n = Convert.ToInt32(Console.ReadLine());

        var fibonacci = new int[n];

        fibonacci[0] = 1;
        var currentValue = 0;

        for (var i = 1; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + currentValue;
            currentValue = fibonacci[i - 1];
        }

        foreach (var i in fibonacci)
        {
            Console.WriteLine(i);
        }
    }

    public static void Atividade6()
    {
        Console.WriteLine("Insira o número");
        var n = Convert.ToInt32(Console.ReadLine());

        while (n != 1)
        {
            Console.WriteLine(n);
            //vou considerar 0 como par, pois no enunciado só difere de impar e par
            if (n % 2 == 0)
            {
                n = n / 2;
                continue;
            }

            n = n * 3 + 1;
        }
        /* O que acontece é, o algorítimo tenta transformar o valor
         em um número que é potencia de 2, podendo assim dividir pela
         metade até chegar a 2, novamente dividido pela metade gerando 
         o resultado "1", que interrompe o loop
         */
    }

    public static void Atividade7()
    {
        Console.WriteLine("=======");
        Console.WriteLine("MEDIANA");
        Console.WriteLine("=======");
        Console.WriteLine();

        Console.WriteLine("Insira o menor valor");
        var menorValor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira o maior valor");
        var maiorValor = Convert.ToInt32(Console.ReadLine());


        var qtdNumbers = maiorValor - menorValor;

        var numbers = new int[qtdNumbers + 1];

        for (var i = menorValor; i <= maiorValor; i++)
        {
            numbers[i - menorValor] = i;
        }

        Console.Write($"A mediana da sequencia: ");


        Console.WriteLine(string.Join(", ", numbers));

        Console.Write("É: ");

        if (numbers.Length % 2 == 0)
        {
            var values = (numbers[(numbers.Length / 2) - 1], numbers[numbers.Length / 2]);

            var mediana = (double)(values.Item1 + values.Item2) / 2;
            Console.WriteLine(mediana);
            return;
        }

        var value = numbers[(numbers.Length / 2)];
        Console.WriteLine(value);
    }

    public static void Atividade9()
    {
        var wantAddMore = false;

        var employees = new List<Employee>();
        do
        {
            Console.WriteLine("Sexo do candidato");
            Console.WriteLine("Masculino = 1");
            Console.WriteLine("Feminino = 2");
            var sex = Enum.Parse<Sex>(Console.ReadLine() ?? "1");

            Console.WriteLine("Escolaridade candidato");
            Console.WriteLine("Ensino Fundamental = 1");
            Console.WriteLine("Ensino Médio = 2");
            Console.WriteLine("Ensino Superior = 3");
            Console.WriteLine("Pós graduação = 4");
            var scholarity = Enum.Parse<Scholarity>(Console.ReadLine() ?? "1");


            Console.WriteLine("Insira a idade");
            var age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("O candidato tem experiência? [S/n]");
            var res = Console.ReadLine();

            var isExperient = res.ToLower() != "n";

            employees.Add(new Employee(sex, age, isExperient, scholarity));

            Console.Write("Deseja adicionar mais um funcionário?? [S/n] ");
            var option = Console.ReadLine();

            wantAddMore = !(string.IsNullOrEmpty(option) || option.ToLower() == "n");
            
            Console.Clear();
        } while (wantAddMore);


        int femaleEmployees = 0;
        int maleEmployees = 0;

        var femaleWithExperience = new List<Employee>();

        var maleWithExperience = new List<Employee>();

        var manBetween35And45 = new List<Employee>();


        foreach (var employee in employees)
        {
            if (employee.Sex == Sex.Fem)
            {
                femaleEmployees++;

                if (employee.IsExperient)
                {
                    femaleWithExperience.Add(employee);
                }
            }
            else
            {
                maleEmployees++;
                if (employee.IsExperient)
                {
                    maleWithExperience.Add(employee);
                }

                if (employee.Age is >= 35 and <= 45)
                {
                    manBetween35And45.Add(employee);
                }
            }
        }

        Console.WriteLine($"Candidatas: {femaleEmployees}");
        Console.WriteLine($"Candidatos: {maleEmployees}");

        uint totalMaleAge = 0;
        foreach (var emp in maleWithExperience)
        {
            totalMaleAge += emp.Age;
        }

        var avgExpMale = (double)totalMaleAge / maleWithExperience.Count;

        uint totalFemaleAge = 0;
        foreach (var emp in femaleWithExperience)
        {
            totalFemaleAge += emp.Age;
        }

        var avgExpFemale = (double)totalFemaleAge / femaleWithExperience.Count;


        var percentOfManBetween35And45 = (double)manBetween35And45.Count / maleEmployees;

        int minAgeFemaleWithExperience = 0;

        foreach (var employee in femaleWithExperience)
        {
            if (minAgeFemaleWithExperience == 0)
            {
                minAgeFemaleWithExperience = employee.Age;
                continue;
            }

            if (employee.Age < minAgeFemaleWithExperience)
            {
                minAgeFemaleWithExperience = employee.Age;
            }
        }

        Console.WriteLine("Candidatas Femininas: " + femaleEmployees);
        
        Console.WriteLine("Candidatos Masculinos: " + maleEmployees);

        if (avgExpMale is not double.NaN)
        {
            Console.WriteLine("Média de idade dos homens com experiencia: " +
                              avgExpMale.ToString("F2", CultureInfo.InvariantCulture));
        }

        if (avgExpFemale is not double.NaN)
        {
            Console.WriteLine("Média de idade das mulheres com experiencia: " +
                              avgExpFemale.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("Percentagem dos homens entre 35 e 45 anos: " +
                          percentOfManBetween35And45.ToString("P1", CultureInfo.InvariantCulture));
        Console.WriteLine("Menor idade entre as mulheres experientes: " + minAgeFemaleWithExperience);


        Console.WriteLine("Escolaridade: ");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}