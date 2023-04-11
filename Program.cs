var mensagem1 = FormataMensagem("Henrique", 500);
var mensagem2 = FormataMensagem("Maria", 1000);

string FormataMensagem(string nome, decimal valor)
{
    return $"O funcionário {nome} recebe {valor}.";
}