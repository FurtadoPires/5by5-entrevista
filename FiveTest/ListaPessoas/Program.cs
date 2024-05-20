//2 - Criar console application que:
//-Cria uma lista de objetos do tipo Pessoa, sendo que pessoa tem: Nome e Idade.
//- Cria uma segunda lista com os mesmo objetos da Lista 1
//- Imprime no console cada pessoa/idade que está na Lista 2.

using ListaPessoas;

Pessoa pessoa = new Pessoa();
var lista1 = pessoa.ListaPessoas();
var lista2 = lista1;
Console.WriteLine("Exibindo lista 1");
pessoa.ImprimeLista(lista1);
Console.WriteLine("Exibindo lista 2");
pessoa.ImprimeLista(lista2);