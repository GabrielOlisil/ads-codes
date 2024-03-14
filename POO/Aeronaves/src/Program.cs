using Entities;

var voo = new Voo(123, DateTime.Now, 467);

var numVagas = voo.Vagas();

Console.WriteLine($"Numero de vagas: {numVagas}");


var ocupa = voo.Ocupa(1);

Console.WriteLine($"Foi possível ocupar: {ocupa}");


var isLivre = voo.Verifica(1);

Console.WriteLine($"A poltrona 1 estpa livre: {isLivre}");


numVagas = voo.Vagas();

Console.WriteLine($"Numero de vagas: {numVagas}");


var proximoLivre = voo.ProximoLivre();

Console.WriteLine($"Proximo livre: {proximoLivre}");

