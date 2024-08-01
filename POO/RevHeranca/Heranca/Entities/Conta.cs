using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities;

class Conta
{
    public int NConta { get; private set; }
    public string Agencia { get; private set; }
    public string Titular { get; private set; }

    protected double Saldo;

    public Conta(int nConta, string agencia, string titular, double saldo)
    {
        NConta = nConta;
        Agencia = agencia;
        Titular = titular;
        Saldo = saldo;
    }

    public double GetSaldo()
    {
        return Saldo;
    }


    /// <summary>
    /// Saca o saldo da conta, se valor suficiente
    /// </summary>
    /// <param name="valor"></param>
    public virtual void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque no valor de {valor} realizado com sucesso");
            return;
        }
        Console.WriteLine("Saldo insuficiente");
    }


    /// <summary>
    /// Deposita um valor na conta
    /// </summary>
    /// <param name="valor"></param>
    public virtual void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Deposito no valor de {valor} realizado com sucesso");
        }
        Console.WriteLine("Impossível depositar um valor nulo ou negativo");
    }


  
}
