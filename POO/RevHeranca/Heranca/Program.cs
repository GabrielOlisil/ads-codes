using Heranca.Entities;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;


Console.WriteLine("Deseja criar uma conta 1. estudante ou 2. empresarial (1/2)");
var opcao = Console.ReadLine();

if(opcao == "1")
{

    Console.WriteLine("Insira o numero da conta");
    var nacc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira a agencia");
    var agencia = Console.ReadLine()!;

    Console.WriteLine("Insira o titular");
    var titular = Console.ReadLine()!;

    Console.WriteLine("Insira o saldo inicial");
    var saldo = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Insira o limite de cheque especial");
    var limiteChequeEspecial = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o cpf");
    var cpf = Console.ReadLine()!;

    Console.WriteLine("Insira o nome da instituição");
    var nomeInstituicao = Console.ReadLine()!;


    var conta = new ContaEstudante(nacc, agencia, titular, saldo, limiteChequeEspecial, cpf, nomeInstituicao);


    Console.WriteLine("Insira o valor do primeiro deposito");
    var deposito = Convert.ToDouble(Console.ReadLine());
    conta.Depositar(deposito);


    Console.WriteLine("Insira o valor do saque");
    var saque = Convert.ToDouble(Console.ReadLine());

    conta.Sacar(saque);


}
else
{
    Console.WriteLine("Insira o numero da conta");
    var nacc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira a agencia");
    var agencia = Console.ReadLine()!;

    Console.WriteLine("Insira o titular");
    var titular = Console.ReadLine()!;

    Console.WriteLine("Insira o saldo inicial");
    var saldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira a anuidade");
    var anuidade = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o limite de emprestimo");
    var limEmprestimo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o total emprestimos");
    var totalEmprestimo = Convert.ToDouble(Console.ReadLine());


    var acc = new ContaEmpresarial(nacc, agencia, titular, saldo, anuidade, limEmprestimo, totalEmprestimo);


    Console.WriteLine("Insira o valor do primeiro deposito");
    var deposito = Convert.ToDouble(Console.ReadLine());
    acc.Depositar(deposito);


    Console.WriteLine("Insira o valor do saque");
    var saque = Convert.ToDouble(Console.ReadLine());

    acc.Sacar(saque);


    Console.WriteLine("Insira o valor do emprestimo");
    var emprestimo = Convert.ToDouble(Console.ReadLine());

    acc.FazerEmprestimo(emprestimo);
}




