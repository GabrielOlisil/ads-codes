namespace Entities;

class Conta
{
  private int _id;
  private string _agencia = string.Empty;
  private string _nConta = string.Empty;
  private string _proprietario = string.Empty;
  private decimal _saldo;


  // -----------


  public void SetId(int id)
  {
    _id = id;
  }

  public int GetId()
  {
    return _id;
  }


  public void SetAgencia(string agencia)
  {
    _agencia = agencia;
  }

  public string GetAgencia()
  {
    return _agencia;
  }

  public void SetNConta(string nConta)
  {
    _nConta = nConta;
  }

  public string GetNConta()
  {
    return _nConta;
  }

  public void SetProprietario(string proprietario)
  {
    _proprietario = proprietario;
  }

  public string GetProprietario()
  {
    return _proprietario;
  }

  public void SetSaldo(decimal saldo)
  {

    if (saldo <= 0)
    {
      return;
    }
    _saldo = saldo;
  }


  public decimal GetSaldo()
  {
    return _saldo;
  }


  // -----------


  public void Depositar(decimal valor)
  {
    if (valor <= 0)
    {
      return;
    }
    _saldo += valor;
  }

  public void Transferir(Conta destino, decimal valor)
  {
    if (valor > _saldo)
    {
      return;
    }
    destino.SetSaldo(_saldo);
    _saldo -= valor;
  }
}
