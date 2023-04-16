using modelo;

var pessoa = new Pessoa("XPTO", 42, new Endereco("Rua X", "42", "Y", "Ok"));
var carro = new Carro();
PreencheObjeto(carro);

Console.WriteLine(carro.Nome);

void PreencheObjeto(Carro carro)
{
    carro.Nome = "Gol";
    carro.Ano = 2021;
}

class Carro
{
    public string Nome;
    public int Ano;
}
