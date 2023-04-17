// Criar um modelo que irá receber os items para compra do mês, nesse modelo teremos a data que a
// compra irá acontecer, mercado e os itens para comprar.

using modelo;

var compraDoMes = new CompraDoMes(DateTime.Now, "XPTO",
    new List<string>() { "pasta de dente", "sabonete", "sabão de pó" });

Console.WriteLine($"Data da compra: {compraDoMes.Data}");
Console.WriteLine($"Estabelecimento: {compraDoMes.Mercado}");

Console.WriteLine("Itens comprados:");
for (int i = 0; i < compraDoMes.Itens.Count(); i++)
    Console.WriteLine($"- {compraDoMes.Itens[i]}");
