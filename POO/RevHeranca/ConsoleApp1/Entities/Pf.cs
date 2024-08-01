using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities;

class Pf: Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Formacao { get; set; }
}
