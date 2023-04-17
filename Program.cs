using modelo;

var carro = new Carro("Gol", 2021);

Console.WriteLine(carro.Nome);
Console.WriteLine(carro.Nome);


class Carro
{
    public string Nome { get; private set; }
    public int Ano { get; private set; }

    public Carro(string nome, int ano)
    {
        Nome = nome;
        Ano = ano;
    }
}
