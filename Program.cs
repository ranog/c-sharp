var lista = new List<int>();

for (var i = 0; i < 100; i++)
    lista.Add(i);

for (var i = 0; i < lista.Count(); i++)
    Console.WriteLine(lista[i]);