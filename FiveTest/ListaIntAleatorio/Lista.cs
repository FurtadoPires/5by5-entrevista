using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIntAleatorio
{
    public class Lista
    {
        public List<int> GerarLista()
        {
            Random random = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                lista.Add(random.Next(255));
            }
            return lista;
        }

        public void ImprimeLista(List<int> lista)
        {
            foreach (var item in lista)
            {
                Console.Write(item);
                Console.Write(", ");
            }
            Console.WriteLine();
        }

        public void ImprimeListaInvertida(List<int> lista)
        {
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                Console.Write(lista[i]);
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

    }


}
