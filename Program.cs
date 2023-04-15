var endereco = new Endereco();
endereco.Rua = "Rua X";
endereco.Numero = "42";
endereco.Cidade = "Y";
endereco.Estado = "OK";

Console.WriteLine(endereco.Rua);

struct Endereco{
    public string Rua;
    public string Numero;
    public string Cidade;
    public string Estado;
}
