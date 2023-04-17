namespace modelo;

public class CompraDoMes
{
    public DateTime Data { get; set; }
    public string Mercado { get; set; }
    public List<string> Itens { get; set; }

    public CompraDoMes(DateTime data, string mercado, List<string> itens)
    {
        Data = data;
        Mercado = mercado;
        Itens = itens;
    }
}
