public class Infracao
{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
    public decimal ValorAplicado { get; set; }
    public Veiculo Veiculo { get; set; }
    public Proprietario Proprietario { get; set; }
    public Multa Multa { get; set; }
}
