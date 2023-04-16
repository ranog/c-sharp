namespace modelo;

struct Endereco
{
    public string Rua;
    public string Numero;
    public string Cidade;
    public string Estado;
    public bool Valido;

    public Endereco(string rua, string numero, string cidade, string estado)
    {
        Rua = rua;
        Numero = numero;
        Cidade = cidade;
        Estado = estado;
        Valido = false;
        Validar();
    }

    private void Validar()
    {
        if (string.IsNullOrEmpty(Rua) || string.IsNullOrEmpty(Numero) || string.IsNullOrEmpty(Cidade) ||
            string.IsNullOrEmpty(Estado))
            Valido = false;
        else
        {
            Valido = true;
        }
    }

    public string EnderecoCompleto()
    {
        return $"{Rua}, {Numero}, {Cidade} - {Estado}";
    }
}
