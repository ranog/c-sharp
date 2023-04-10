// Dado uma lista com os itens "2, 8, 3, 10, 5, 4, 7, 9, 1" que vão de 1 a 10, efetuar a soma em duas
// variáveis, a primeira números de 1 a 5 e a segunda de 6 a 10. Imprimir dos dois resultados.

var data = new List<int> { 2, 8, 3, 10, 5, 4, 7, 9, 1 };

var first_data = data.Where(f => f < 6);
var second_data = data.Where(s => s > 5);

var sum_of_first_data = first_data.Sum();
var sum_of_second_data = second_data.Sum();

Console.WriteLine("Resultados das somas:");
Console.WriteLine($"Soma dos primeiros dados = {sum_of_first_data}");
Console.WriteLine($"Soma dos segundos dados = {sum_of_second_data}");