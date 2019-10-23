using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                int n;
                Console.WriteLine("Quantas termos deseja somar?");
                n = int.Parse(Console.ReadLine());
                int[] numero = new int[n];
                int soma = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Digite um número para o posição {0} ", i + 1);
                    numero[i] = int.Parse(Console.ReadLine());
                    soma += numero[i];
                }
                int j;
                Console.WriteLine("Qual posição deseja saber o número? ");
                j = int.Parse(Console.ReadLine());
                if (j <= n && j > 0)
                {
                    Console.WriteLine("O número da posição {0} é {1} e a soma total é {2}", j, numero[j - 1], soma);
                }
                else
                {
                    Console.WriteLine("Posição inválida!, mas a soma é {0}", soma);
                }
                Console.WriteLine("Deseja fazer de novo? 1 - SIM / 2 - NÃO");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcao==1);
            if (opcao!=1)
            {
                Console.WriteLine("Obrigado!!!");
                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
