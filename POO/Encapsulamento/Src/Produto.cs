class Produto
{

    // Crie uma classe Produto que possui os seguintes atributos: Código do produto,
    // descrição (o nome do produto), unidade (LT, CX, KG, UN, MT), preço,
    // quantidade em estoque.
    // a) O preço de um produto só pode ser valores maiores de zero;
    // b) O tipo de unidade do produto deve estar dentro das opções listadas

    private Guid _codigo;
    private string? _descricao;
    private string? _unidade;
    private double _preco;
    private int _qtdEstoque;

    private string[] unidadeControle = new string[] { "LT", "CX", "KG", "UN", "MT" };

    public Produto()
    {
        _codigo = Guid.NewGuid();
    }


    public void setPreco(double preco)
    {
        if (preco < 0)
        {
            return;
        }
        _preco = preco;
    }

    public double getPreco() => _preco;


    public void setUnidade(string unidade)
    {
        if (!unidadeControle.Contains(unidade))
        {
            return;
        }
        _unidade = unidade;
    }

    public string getUnidade() => _unidade ?? string.Empty;

    public void setQtdEstoque(int qtd)
    {
        if (qtd < 0)
        {
            return;
        }
        _qtdEstoque = qtd;
    }


    public int qtdEstoque() => _qtdEstoque;


    public void setDescricao(string descricao)
    {
        if (string.IsNullOrEmpty(descricao))
        {
            return;
        }
        _descricao = descricao;
    }

    public string getDescricao() => _descricao ?? string.Empty;



    public override string ToString()
    {
        string text = string.Empty;

        text += $"Codigo: {_codigo}\n" +
          $"Descricao: {_descricao}\n" +
          $"Unidade: {_unidade}\n" +
          $"Preco: {_preco}\n" +
          $"Quantidade em estoque: {_qtdEstoque}\n";

        return text;

    }
}
