namespace modelo;

public class Compras
{
    public DateTime Data { get; set; }
    public string Mercado { get; set; } = default!;
    public List<string> Itens{get; set;}

    public Compras(DateTime data, string mercado, List<string> itens)
    {








        Data = data;
        Mercado = mercado;
        Itens = itens;
    }
}
