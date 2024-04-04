using static Validacao;


public class ProprietarioFisico : Proprietario
{
    private string _cpf;
    public string Rg { get; set; }
    public DateTime DataNascimento { get; set; }
    public Sexo Sexo { get; set; }
    public Cnh Cnh { get; set; }


    public string GetCpf() => _cpf;

    public void SetCpf(string cpf)
    {
        if (!ValidaCPF(cpf))
        {
            throw new Exception("CPF INVÀLIDO");
        }

        _cpf = cpf;

    }
}
