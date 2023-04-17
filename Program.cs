var pessoa = new Pessoa("XPTO");
Console.WriteLine(pessoa.Nome);
Console.WriteLine(pessoa.Idade);

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
