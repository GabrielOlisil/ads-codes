using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao.Entities;

class Passeio : Veiculo
{

    public Passeio(int qtdEixos, string placa, int tipo) 
        : base(qtdEixos, placa, tipo) { }

 
    public override void CalcularPedagio()
    {
        var pedagio = 3.0 * QtdEixos;
       
        PrecoPedagio = pedagio;

        CalcularDesconto();
    }
}
