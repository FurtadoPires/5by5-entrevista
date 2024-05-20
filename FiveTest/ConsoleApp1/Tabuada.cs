using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjTabuada
{

    public class Tabuada
    {
        public void ImprimeTabuada(int n)
        {
            Console.WriteLine($"Imprimindo a tabuada do numero {n}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }        

        }
        public void ValidaValor(string valor)
        {
            bool isNum = false;
            int val;

            do
            {    
                if (!int.TryParse(valor, out val)) {
                    Console.WriteLine("Valor inserido não é um número inteiro. Por favor, digite um número de 1 a 10: ");
                }
                else if (val <= 1 || val > 10)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número de 1 a 10: ");
                }else { isNum = true; }

                if (!isNum) {
                    valor = Console.ReadLine();
                }
            }while (!isNum);

            ImprimeTabuada(val);
        }
    }
}
