using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities;

class ContaEstudante : Conta
{


    public double LimiteChequeEspecial { get; private set; }
    public string Cpf { get; private set; }
    public string NomeInstituicao { get; private set; }



    public ContaEstudante(int nConta, string agencia, string titular, double saldo, double limiteChequeEspecial, string cpf, string nomeInstituicao)
        : base(nConta, agencia, titular, saldo)
    {
        LimiteChequeEspecial = limiteChequeEspecial;
        Cpf = cpf;
        NomeInstituicao = nomeInstituicao;
    }


    public override void Sacar(double valor)
    {
        if (Saldo + LimiteChequeEspecial >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque no valor de {valor} realizado com sucesso");
            return;
        }

        Console.WriteLine("Limite insuficiente");

    }
}
