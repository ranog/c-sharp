(var resultado1, var mensagem1) = FormataMensagem("Henrique", 499);
if (resultado1)
    Console.WriteLine(mensagem1);

(var resultado2, var mensagem2) = FormataMensagem("Maria", 1000);
if (resultado2)
    Console.WriteLine(mensagem2);

(bool, string) FormataMensagem(string nome, decimal valor)
{
    if (valor < 500)
        return (false, string.Empty);
    var mensagem = $"O funcionário {nome} recebe {valor}.";
    return (true, mensagem);
}