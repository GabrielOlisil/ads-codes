public abstract class Proprietario
{

    public int Id { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Tipo { get; set; }
    public Endereco Endereco { get; set; }
}
