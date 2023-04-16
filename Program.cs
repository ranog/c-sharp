var endereco = new Endereco(rua: "Rua X", numero: "42", cidade: "Y", estado: "OK");

Console.WriteLine(endereco.EnderecoCompleto());

struct Endereco
{
    public string Rua;
    public string Numero;
    public string Cidade;
    public string Estado;

    public Endereco(string rua, string numero, string cidade, string estado)
    {
        Rua = rua;
        Numero = numero;
        Cidade = cidade;
        Estado = estado;
    }

    public string EnderecoCompleto()
    {
        return $"{Rua}, {Numero}, {Cidade} - {Estado}";
    }
}
