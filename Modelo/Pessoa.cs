namespace modelo;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public Endereco Endereco;

    public Pessoa(string nome, int idade, Endereco endereco)
    {
        Nome = nome;
        Idade = idade;
        Endereco = endereco;
    }
}
