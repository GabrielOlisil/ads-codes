using System.Diagnostics.CodeAnalysis;

namespace Entities;

public class Prova
{
    private Gabarito _gabarito;
    private List<char> _respostas = new List<char>();
    private int _valorPorAlternativa;
    private int _nota;

    public int ValorPorAlternativa { get => _valorPorAlternativa; }

    public Prova(Gabarito gabarito)
    {
        _gabarito = gabarito;
    }

    public void setRespostas(char[] respostas)
    {
        for (int i = 0; i < respostas.Length; i++)
        {
            if (respostas[i].ToString().ToLower() != "a" && respostas[i].ToString().ToLower() != "b" && respostas[i].ToString().ToLower() != "c" && respostas[i].ToString().ToLower() != "d" && respostas[i].ToString().ToLower() != "e")
            {
                Console.WriteLine("Insira Alternativas válidas (de A a E)");
                return;
            }

        }

        _valorPorAlternativa = 10 / _respostas.ToArray().Length;
    }

    public void RespostaAluno(char resposta)
    {
        _respostas.Add(resposta);
    }


    public int Acertos()
    {
        int questao = 0;
        int acertos = 0;
        foreach (var resposta in _respostas)
        {
            if (resposta == _respostas[questao])
            {
                acertos++;
            }
            questao++;
        }

        return acertos;
    }
    public double Nota()
    {
        return _valorPorAlternativa * Acertos();
    }


    public double Maior(Prova outra)
    {
        if (Acertos() == outra.Acertos())
        {
      
            if (Acertos() * ValorPorAlternativa >= outra.Acertos() * outra.ValorPorAlternativa)
            {
                return Nota();
            }

            return outra.Nota();
        }

        if (Acertos() > outra.Acertos())
        {
            return Nota();
        }
        return outra.Nota();

    }
}
