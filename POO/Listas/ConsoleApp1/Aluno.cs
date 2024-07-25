using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aluno
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public Endereco Endereco { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}, Matrícula: {Matricula}, Cpf: {Cpf}, Email: {Email}, Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}";
    }
}

