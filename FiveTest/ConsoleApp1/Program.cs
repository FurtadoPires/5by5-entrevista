//1 - Criar console application que:
//-Recebe um número inteiro entre 1 e 10
//- Escreve no console a tabuada completa para o número recebido.

using ProjTabuada;
Tabuada tabuada = new Tabuada();
Console.Write("Por favor digite um número de 1 a 10: ");
tabuada.ValidaValor(Console.ReadLine());
Console.WriteLine("Pressione qualquer tecla para continuar");
Console.ReadLine();
