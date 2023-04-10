ExibeMensagem("Henrique", 500);
ExibeMensagem("Maria", 1000);

void ExibeMensagem(string nome, decimal valor)
{
    Console.WriteLine($"O funcionário {nome} recebe {valor}.");    
}