var lista = new List<int>();

lista.Add(5);
lista.Add(4);
lista.Add(1);
lista.Add(3);
lista.Add(10);
lista.Add(2);
lista.Add(8);

//var sublist = lista.Where(l => l > 5);
var sublist = new List<int>();
for (var i = 0; i < lista.Count(); i++)
    if (lista[i] > 5)
        sublist.Add(lista[i]);

for (var i = 0; i < sublist.Count(); i++)
    Console.WriteLine(sublist.ElementAt(i));
    
var sublista = lista.Where(l => l > 5 && l < 10);
for (var i = 0; i < sublista.Count(); i++)
    Console.WriteLine(sublista.ElementAt(i));