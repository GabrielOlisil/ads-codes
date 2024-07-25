using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Endereco
{
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public int Numero { get; set; }

    public override string ToString()
    {
        return $"Rua: {Rua}, Bairro: {Bairro}, Numero: {Numero}";
    }
}

