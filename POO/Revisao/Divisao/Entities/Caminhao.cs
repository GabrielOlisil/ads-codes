using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao.Entities;

class Caminhao : Veiculo
{
    public Caminhao(int qtdEixos, string placa, int tipo) 
        : base(qtdEixos, placa, tipo) { }



    public override void CalcularPedagio()
    {
        var pedagio = 7.0 * QtdEixos;


        pedagio = pedagio + (pedagio * 0.1);

        CalcularDesconto();
    }
}
