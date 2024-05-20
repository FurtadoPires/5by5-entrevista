using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPessoas
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public List<Pessoa> ListaPessoas()
        {
            string incl = "+";
            List<Pessoa> lista = new List<Pessoa>();
            do
            {
                Console.WriteLine();
                Pessoa pessoa = new Pessoa();
                Console.Write("Digite o nome da pessoa: ");
                pessoa.Nome = ValidaNome(Console.ReadLine());
                Console.Write("Digite a idade da pessoa: ");
                pessoa.Idade = ValidaIdade(Console.ReadLine());
                lista.Add(pessoa);

                Console.WriteLine("Digite + se deseja incluir mais alguém na lista:");
                incl = (Console.ReadLine());
            } while (incl == "+");

            return lista;
        }

        public string ValidaNome(string nome)
        {
            while (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Campo nome não pode ser vazio, digite um valor para o nome");
                nome = Console.ReadLine();
            }
            return nome;
        }

        public int ValidaIdade(string valor)
        {
            bool isNum = false;
            int val;

            do
            {
                if (!int.TryParse(valor, out val))
                {
                    Console.WriteLine("Valor inserido não é um número inteiro. Por favor, digite um número: ");
                }
                else if (val < 0)
                {
                    Console.WriteLine("Idade Inválida. Por favor, digite uma idade válida: ");
                }
                else { isNum = true; }

                if (!isNum)
                {
                    valor = Console.ReadLine();
                }
            } while (!isNum);
            return val;
        }

        public void ImprimeLista(List<Pessoa> lista)
        {
            foreach (Pessoa p in lista)
            {
                Console.WriteLine($"Nome: {p.Nome}");
                Console.WriteLine($"Idade: {p.Idade}");
                Console.WriteLine();
            }
        }
    }
}
