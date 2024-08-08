// See https://aka.ms/new-console-template for more information

using Divisao.Entities;

try
{
    Console.WriteLine("Selecione as seguintes categorias");
    Console.WriteLine("1 Passeio");
    Console.WriteLine("2 Utilitario");
    Console.WriteLine("3 Onibus");
    Console.WriteLine("4 Caminhão");
    var categoria = int.Parse(Console.ReadLine());


    Console.WriteLine("Insira o Tipo do veículo");
    Console.WriteLine("1");
    Console.WriteLine("2");
    Console.WriteLine("3");
    var tipo = int.Parse(Console.ReadLine());

    Console.WriteLine("Insira a quantidade de eixos");
    var qteEixos = int.Parse(Console.ReadLine());


    Console.WriteLine("Insira a placa");
    var placa = Console.ReadLine() ?? "";

    Veiculo? veiculo = null;

    switch (categoria)
    {
        case 1:
            veiculo = new Passeio(qteEixos, placa, tipo);
            break;
        case 2:
            veiculo = new Utilitario(qteEixos, placa, tipo);
            break;
        case 3:
            veiculo = new Onibus(qteEixos, placa, tipo);
            break;
        case 4:
            veiculo = new Caminhao(qteEixos, placa, tipo);
            break;

    }


    if (veiculo is not null)
    {
        Console.WriteLine($"O valor do pedágio é {veiculo.ValorFinal}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
