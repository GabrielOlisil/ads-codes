public class ProprietarioFisico : Proprietario
{
    public int Id { get; set; }
    private string _cpf;
    public string Rg { get; set; }
    public DateTime DataNascimento { get; set; }
    public Sexo sexo { get; set; }
    public Cnh Cnh { get; set; }


    public string GetCpf() => _cpf;

    public void SetCpf()
    {
        //Lógica de validar cpf
    }
}
