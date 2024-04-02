var lista = new List<Produto>();

while (true)
{
    Console.WriteLine("Qual operação deseja fazer??");
    Console.WriteLine("1 Ver lista");
    Console.WriteLine("2 Inserir produto");
    Console.WriteLine("3 Remover Produto");

    string? resposta = Console.ReadLine();

    switch (resposta)
    {
        case "1":
            Console.WriteLine("\n======= Produtos ======= ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            break;

        case "2":
            var produto = new Produto();

            Console.WriteLine("Insira a descrição do produto");
            produto.setDescricao(Console.ReadLine()!);

            Console.WriteLine("Insira a unidade: LT, CX, KG, UN, MT");
            produto.setUnidade(Console.ReadLine()!);

            Console.WriteLine("Insira o preço");
            produto.setPreco(double.Parse(Console.ReadLine()!));

            Console.WriteLine("Insira a quantidade em estoque");
            produto.setQtdEstoque(int.Parse(Console.ReadLine()!));

            lista.Add(produto);
            break;

        case "3":
            Console.WriteLine("Qual elemento voce quer remover (numero)");
            var numero = int.Parse(Console.ReadLine()!);

            lista.RemoveAt(numero);


            break;
        default:
            Environment.Exit(0);
            break;
    }
    Console.ReadKey();
    Console.Clear();
}
