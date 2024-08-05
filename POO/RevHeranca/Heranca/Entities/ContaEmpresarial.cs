using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities;

class ContaEmpresarial : Conta
{
    public ContaEmpresarial(int nConta, string agencia, string titular, double saldo, double anuidade, double limiteEmprestimo, double totalEmprestimo)
        : base(nConta, agencia, titular, saldo)
    {
        Anuidade = anuidade;
        LimiteEmprestimo = limiteEmprestimo;
        TotalEmprestimo = totalEmprestimo;
    }

    public double Anuidade { get; private set; }
    public double LimiteEmprestimo { get; private set; }
    public double TotalEmprestimo { get; private set; }


    public void FazerEmprestimo(double valor)
    {
        if (valor <= LimiteEmprestimo)
        {
            Saldo += valor;
            TotalEmprestimo += valor;
            Console.WriteLine("Emprestimo realizado com sucesso");
            return;
        }
        Console.WriteLine("Valor de emprestimo não pode ser concedido");
    }

    public override void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo Insuficiente");
            return;
        }

        if (valor > 5000)
        {
            if (valor > (Saldo + 5))
            {
                Console.WriteLine("Saldo Insuficiente");
                return;
            }

            Saldo -= 5;

        }
        Saldo -= valor;
        Console.WriteLine($"Saque no valor de {valor} realizado com sucesso");
    }
}
