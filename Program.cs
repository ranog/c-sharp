FormataMensagem("Henrique", 500, out var mensagem1);
Console.WriteLine(mensagem1);

FormataMensagem("Maria", 1000, out var mensagem2);
Console.WriteLine(mensagem2);

void FormataMensagem(string nome, decimal valor, out string mensagem)
{
    mensagem = $"O funcionário {nome} recebe {valor}.";
}