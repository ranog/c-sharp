var resultado1 = FormataMensagem("Henrique", 499, out var mensagem1);
if(resultado1)
    Console.WriteLine(mensagem1);

var resultado2 = FormataMensagem("Maria", 1000, out var mensagem2);
if(resultado2)
    Console.WriteLine(mensagem2);

bool FormataMensagem(string nome, decimal valor, out string mensagem)
{
    mensagem = string.Empty;
    if (valor < 500)
        return false;
    mensagem = $"O funcionário {nome} recebe {valor}.";
    return true;
}