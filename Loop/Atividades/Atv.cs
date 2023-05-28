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


        var a = 0;
        var b = 1;
        int c;

        Console.WriteLine($"{a}\n{b}");

        for (var i = 2; i < n; i++)
        {
            c = a + b;
            Console.WriteLine($"{c}");
            a = b;
            b = c;


        }
        Console.ReadKey();


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


        var tamanhoSequencia = (maiorValor - menorValor) + 1;
        double mediana;

        if (tamanhoSequencia % 2 == 0)
        {

            (int, int) indicesMediana = (tamanhoSequencia / 2 - 1, tamanhoSequencia / 2);
            (int, int) valoresMediana = (0, 0);
            for (var i = menorValor; i <= maiorValor; i++)
            {
                if (i == (indicesMediana.Item1 + menorValor))
                {
                    valoresMediana.Item1 = i;
                }
                if (i == (indicesMediana.Item2 + menorValor))
                {
                    valoresMediana.Item2 = i;
                }

            }
            mediana = (double)valoresMediana.Item1 / valoresMediana.Item2;

        }
        else
        {
            var indiceMediana = tamanhoSequencia / 2;

            for (var i = menorValor; i <= maiorValor; i++)
            {
                if (i == indiceMediana + menorValor)
                {
                    Console.WriteLine($"{i}");

                }
            }

        }




        Console.ReadKey();


    }

    public static void Atividade9()
    {
        var wantAddMore = false;

        uint maleApplicants = 0, maleWithExperience = 0, totalAgeMaleWithExperience = 0;
        uint maleApplicantsBetween35And45 = 0;
        uint femaleApplicants = 0, femaleWithExperience = 0, totalAgeFemaleWithExperience = 0;
        byte minorFemaleAge = 0;
        uint ensinoMedio = 0, ensinoFundamental = 0, ensinoSuperior = 0, posGraduacao = 0;

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

            var isExperient = res?.ToLower() != "n";

            switch (scholarity)
            {
                case Scholarity.EnsinoFundamental:
                    ensinoFundamental++;
                    break;
                case Scholarity.EnsinoMedio:
                    ensinoMedio++;
                    break;
                case Scholarity.EnsinoSuperior:
                    ensinoSuperior++;
                    break;
                case Scholarity.PosGraduacao:
                    posGraduacao++;
                    break;

            }


            if (sex is Sex.Masc)
            {
                maleApplicants++;

                if (isExperient)
                {
                    maleWithExperience++;
                    totalAgeMaleWithExperience += age;
                }

                if (age is >= 35 and <= 45)
                {
                    maleApplicantsBetween35And45++;
                }
            }
            else /* Se Feminino */
            {
                femaleApplicants++;

                if (isExperient)
                {
                    femaleWithExperience++;
                    totalAgeFemaleWithExperience += age;

                    if (femaleWithExperience == 1)
                    {
                        minorFemaleAge = age;
                    }
                    else if (age < minorFemaleAge)
                    {
                        minorFemaleAge = age;
                    }
                }


            }




            Console.WriteLine($"O candidato nº {maleApplicants + femaleApplicants} tem a escolaridade de: {scholarity}");

            Console.Write("Deseja adicionar mais um funcionário?? [S/n] ");
            var option = Console.ReadLine();

            wantAddMore = !(string.IsNullOrEmpty(option) || option.ToLower() == "n");

            Console.Clear();
        } while (wantAddMore);

        var percentageManBetween35And45 = (double)maleApplicantsBetween35And45 / maleApplicants;


        Console.WriteLine($"Total candidatos homens: {maleApplicants}");

        Console.WriteLine($"Total candidatas mulheres: {femaleApplicants}");

        Console.WriteLine($"Media de Idade Homens com experiencia: {((double)totalAgeMaleWithExperience / maleWithExperience).ToString("F2", CultureInfo.InvariantCulture)}");

        Console.WriteLine($"Media de Idade Mulheres com experiencia: {((double)totalAgeFemaleWithExperience / femaleWithExperience).ToString("F2", CultureInfo.InvariantCulture)}");

        Console.WriteLine($"Percentagem dos homens com experiencia entre 35 e 45 anos: {percentageManBetween35And45.ToString("P2", CultureInfo.InvariantCulture)}");

        Console.WriteLine($"Menor idade entre as mulheres com experiencia: {minorFemaleAge}");

        Console.WriteLine($"Total de candidatos com escolaridade Ensino Fundamental: {ensinoFundamental}");
        Console.WriteLine($"Total de candidatos com escolaridade Ensino Médio: {ensinoMedio}");
        Console.WriteLine($"Total de candidatos com escolaridade Ensino Superior: {ensinoSuperior}");
        Console.WriteLine($"Total de candidatos com escolaridade pós graduado: {posGraduacao}");


        Console.ReadKey();

    }

    public static void Atividade10()
    {
        bool wantAddMore = false;
        uint numberOfEmployee = 0;

        double totalINSS = 0, totalIRRF = 0, totalEmployee = 0;

        do
        {
            Console.Clear();

            numberOfEmployee++;
            Console.WriteLine($"Informe o valor do salário");
            var salarioBruto = Convert.ToDouble(Console.ReadLine());

            double salarioLiquido = salarioBruto;



            if (salarioBruto <= 1556.94)
            {
                salarioLiquido -= (salarioBruto * 0.08);
            }
            else if (salarioBruto <= 2594.92)
            {
                salarioLiquido -= (salarioBruto * 0.09);
            }
            else if (salarioBruto <= 5189.82)
            {
                salarioLiquido -= (salarioBruto * 0.11);
            }


            double totalDeduzidoINSS = salarioBruto - salarioLiquido;
            totalINSS += totalDeduzidoINSS;

            Console.WriteLine($"O INSS reteu {totalDeduzidoINSS.ToString("C2")}, do salário");

            var descontoIRRF = 0.0;


            if (salarioLiquido <= 1903.98)
            {

            }
            else if (salarioLiquido <= 2626.65)
            {
                descontoIRRF = (salarioLiquido * 0.075 - 142.8);
            }
            else if (salarioLiquido <= 3751.05)
            {
                descontoIRRF = (salarioLiquido * 0.15 - 354.8);
            }
            else if (salarioLiquido <= 4664.68)
            {
                descontoIRRF = (salarioLiquido * 0.225 - 636.13);
            }
            else
            {
                descontoIRRF = (salarioLiquido * 0.275 - 869.36);
            }


            salarioLiquido -= descontoIRRF;
            totalIRRF += descontoIRRF;






            totalEmployee += salarioLiquido;

            Console.WriteLine($"Para Imposto de Renda, foi retido: {descontoIRRF.ToString("C2")} na fonte, totalizando um salário líquido de {salarioLiquido.ToString("C2")}");

            Console.WriteLine($"{Environment.NewLine}Deseja Adicionar Mais Um registro? [S/n]");
            var opt = Console.ReadLine();

            wantAddMore = opt?.ToString() == "s";




        } while (wantAddMore);

        Console.WriteLine($"Total Pago à Receita Federal: {totalIRRF.ToString("C2")}");
        Console.WriteLine($"Total Pago ao INSS: {totalINSS.ToString("C2")}");
        Console.WriteLine($"Total Pago à Funcionários: {totalEmployee.ToString("C2")}");


        Console.ReadKey();
    }
}