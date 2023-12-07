using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mais_velho {
    class Program {
        static void Main(string[] args) {

            int n, i, maiorIdade;
            string pessoaMaisVelha;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            pessoaMaisVelha = nomes[0];
            maiorIdade = idades[0];
            for (i = 0; i < n; i++) {
                if (idades[i] > maiorIdade) {
                    maiorIdade = idades[i];
                    pessoaMaisVelha = nomes[i];
                }
            }

            Console.WriteLine("PESSOA MAIS VELHA: " + pessoaMaisVelha);
        }
    }
}