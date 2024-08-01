using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities;

class Cliente
{
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }
}
