using modelo;

var endereco = new Endereco(rua: "Rua X", numero: "42", cidade: "Y", estado: "Ok");

Console.WriteLine(endereco.EnderecoCompleto());
Console.WriteLine(endereco.Valido);
