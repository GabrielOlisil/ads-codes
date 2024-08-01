using ConsoleApp1.Entities;

var listaCliente = new List<Cliente>();

var clientePj = new Pj()
{
    Cnpj = "30.464.925/0001-54",
    Email = "nao_responda@eita.com.br",
    Endereco = new Endereco()
    {
        Bairro = "Boca da Mata",
        Numero = 830,
        Rua = "Rua Geraldo Brasil",
        Cep = "41347-030"
    },
    NomeFantasia = "Eita Nois",
    RazaoSocial = "Eita tecnologia EPP",
    Telefone = "(71) 3700-2626"
};

listaCliente.Add(clientePj);


var clientePf = new Pf()
{
    Cpf = "201.736.985-30",
    Telefone = "49092-717",
    Email = "luana_rocha@acaoi.com.br",
    Endereco = new Endereco()
    {
        Bairro = "Olaria",
        Cep = "49092-717",
        Numero = 417,
        Rua = "Avenida Canal 4"
    },
    Formacao = "Engenharia de Software",
    Nome = "Luana Aparecida Rocha"
};

listaCliente.Add(clientePf);