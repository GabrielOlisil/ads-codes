public class Veiculo
{
    public int Id { get; set; }
    private string _niv;
    public string Placa { get; set; }
    public string NumeroMotor { get; set; }
    public string Renavam { get; set; }
    public Situacao Situacao { get; set; }
    public Modelo Modelo { get; set; }

    public string GetNiv() => _niv;


    public void SetNiv()
    {
        // lógica de validação
    }
}
