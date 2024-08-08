using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao.Entities;

abstract class Veiculo
{
    public int QtdEixos { get; private set; }
    public string? Placa { get; private set; }
    public int Tipo { get; private set; }
    public double PrecoPedagio { get; protected set; }
    public double ValorFinal { get; private set; }


    public Veiculo(int qtdEixos, string placa, int tipo)
    {
        QtdEixos = qtdEixos;
        Placa = placa;
        Tipo = tipo;


        CalcularPedagio();
    }

    public abstract void CalcularPedagio();
    public virtual void CalcularDesconto()
    {
        var desconto = 0.0;

        switch (Tipo)
        {
            case 2:
                desconto = 0.05;
                break;
            case 3:
                desconto = 1;
                break;
        }

        ValorFinal = PrecoPedagio - (PrecoPedagio * desconto);
    }
}
