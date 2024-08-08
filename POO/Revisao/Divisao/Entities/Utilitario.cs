using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao.Entities;

class Utilitario : Veiculo
{
    public Utilitario(int qtdEixos, string placa, int tipo)
        : base(qtdEixos, placa, tipo) { }

    public override void CalcularPedagio()
    {
        var pedagio = 3.5 * QtdEixos;


        pedagio = pedagio + (pedagio * 0.02);

        CalcularDesconto();

    }
}
