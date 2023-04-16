using modelo;

var endereco = new Endereco(rua: "Rua X", numero: "42", cidade: "Y", estado: "Ok");
var pessoa = new Pessoa(nome: "XPTO", idade: 42, endereco: endereco);

Console.WriteLine(pessoa.Nome);
Console.WriteLine(pessoa.Endereco.EnderecoCompleto());
