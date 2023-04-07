var lista = new List<int>();

lista.Add(5);
lista.Add(4);
lista.Add(1);
lista.Add(3);
lista.Add(10);
lista.Add(2);
lista.Add(8);

// for (var i = 0; i < lista.Count(); i++)
//     Console.WriteLine(lista.ElementAt(i));
    
foreach(var x in lista)
    Console.WriteLine(x);
    