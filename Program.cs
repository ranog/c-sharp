var lista = new List<int>();

for (var i = 10; i > 0; i--)
    lista.Add(i);

lista.RemoveAt(2);
lista.Remove(5);

for (var i = 0; i < lista.Count(); i++)
    Console.WriteLine(lista[i]);