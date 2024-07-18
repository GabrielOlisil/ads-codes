using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

class Aluno
{
    private DateTime _dataNasc;
    private int _idade;

    public Aluno(DateTime dataNasc)
    {
        _dataNasc = dataNasc;
        if (dataNasc.Month > DateTime.Now.Month)
        {
            _idade = DateTime.Now.Year - dataNasc.Year - 1;
            return;
        }
        if (dataNasc.Month == DateTime.Now.Month && dataNasc.Day > DateTime.Now.Day)
        {
            _idade = DateTime.Now.Year - dataNasc.Year - 1;
            return;
        }
        _idade = DateTime.Now.Year - dataNasc.Year;
    }

    public DateTime DataNasc { get => _dataNasc; }
    public int Idade { get => _idade; }

    public double Media(double nota1, double nota2)
    {
        var media = (nota1 + nota2) / 2;
        return media;
    }
}
