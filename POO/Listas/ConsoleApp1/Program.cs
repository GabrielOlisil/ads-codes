var endereco = new Endereco
{
    Bairro = "Liberdade",
    Numero = 1,
    Rua = "Rua da Manga"
};

var aluno = new Aluno
{
    Nome = "Gabriel",
    Cpf = "123123123123-01",
    Email = "email",
    DataNascimento = new DateTime(2004, 09, 26),
    Matricula = "9107829",
    Endereco = endereco,
};
var aluno2 = new Aluno
{
    Nome = "Gdilson",
    Cpf = "123123123123-02",
    Email = "email",
    DataNascimento = new DateTime(2005, 09, 26),
    Matricula = "9107829",
    Endereco = endereco,
};
var aluno3 = new Aluno
{
    Nome = "Morgana",
    Cpf = "123123123123-03",
    Email = "email",
    DataNascimento = new DateTime(2006, 09, 26),
    Matricula = "9107829",
    Endereco = endereco,
};
var aluno4 = new Aluno
{
    Nome = "Charles",
    Cpf = "123123123123-04",
    Email = "email",
    DataNascimento = new DateTime(2004, 08, 26),
    Matricula = "9107829",
    Endereco = endereco,
};

var lista = new List<Aluno>();

lista.Add(aluno);
lista.Add(aluno2);
lista.Add(aluno3);
lista.Add(aluno4);

//foreach (var alunao in lista)
//{
//    Console.WriteLine(alunao);
//}


Console.WriteLine(lista.Find(x => x.Nome == "Gabriel"));


var lista2 = lista.Where(x => x.DataNascimento > new DateTime(2004, 09, 26)).ToList();

foreach (var alunao in lista2)
{
    Console.WriteLine(alunao);
}


lista.Remove(aluno);

Console.WriteLine(aluno.Endereco);