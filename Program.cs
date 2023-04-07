var lista = new List<int>();

lista.Add(5);
lista.Add(4);
lista.Add(1);
lista.Add(3);
lista.Add(10);
lista.Add(2);
lista.Add(8);

Console.WriteLine(lista.First());
Console.WriteLine(lista.Last());
    
var sublist = lista.Where(l => l > 5 && l < 10);

for (var i = 0; i < sublist.Count(); i++)
    Console.WriteLine(sublist.ElementAt(i));