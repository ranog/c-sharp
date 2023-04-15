string mensagem = string.Empty;

var resultado = FormataMensagem("Maria", 1000);
if (resultado)
    Console.WriteLine(mensagem);

bool FormataMensagem(string nome, decimal valor)
{
    if (valor < 500)
        return false;
    var mensagem = $"O funcionário {nome} recebe {valor}.";
    return true;
}