//3 - Criar console application que:
//-Cria uma lista contendo 6 números inteiros aleatórios
//- Imprime no console os 6 números da lista separados por vírgula
//- Imprime no console os 6 números da lista de trás pra frente

using ListaIntAleatorio;
Console.WriteLine("Gerando Lista de 6 números aleatórios");
Lista listagem = new Lista();
var listaNum = listagem.GerarLista();
Console.WriteLine("Exibindo lista:");
listagem.ImprimeLista(listaNum);
Console.WriteLine("Exibindo lista invertida");
listagem.ImprimeListaInvertida(listaNum);


Console.WriteLine("Digite qualquer tecla para continuar");
Console.ReadLine();