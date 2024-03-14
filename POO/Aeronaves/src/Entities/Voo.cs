using Lib.Enum;
namespace Entities;

class Voo
{
    private DateTime _dataHora;
    private int _maximoPassageiros; //Boeing 747
    private int _numeroVoo;

    private Ocupacao[] _poltronasOculpadas;

    public Voo(int numeroVoo, DateTime dataHora, int maximoPassageiros)
    {
        _numeroVoo = numeroVoo;
        _dataHora = dataHora;
        _maximoPassageiros = maximoPassageiros;

        _poltronasOculpadas = new Ocupacao[_maximoPassageiros];

    }

    public int ProximoLivre()
    {

        for (int i = 0; i < _poltronasOculpadas.Length; i++)
        {
            if (_poltronasOculpadas[i] is Ocupacao.Desocupado)
            {
                return i + 1;
            }
        }

        return -1;
    }



    public bool Verifica(int numPoltrona) => _poltronasOculpadas[numPoltrona - 1] is Ocupacao.Desocupado;


    public bool Ocupa(int numPoltrona)
    {
        if (_poltronasOculpadas[numPoltrona - 1] is Ocupacao.Ocupado)
        {
            return false;
        }
        _poltronasOculpadas[numPoltrona - 1] = Ocupacao.Ocupado;
        return true;
    }

    public int Vagas()
    {
        int vagas = 0;

        for (int i = 0; i < _poltronasOculpadas.Length; i++)
        {
            if (_poltronasOculpadas[i] is Ocupacao.Desocupado)
            {
                vagas += 1;
            }
        }
        return vagas;
    }


    public void SetVoo(int numVoo)
    {
        _numeroVoo = numVoo;
    }

    public int GetVoo()
    {
        return _numeroVoo;
    }
}
