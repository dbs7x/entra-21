using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            //Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o nome e preço dos sete produtos

            var quantidade = 7;
            var nomes = new string [quantidade];
            var precos = new double [nomes.Length];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome do produto: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < nomes.Length;i++)
            {
            Console.WriteLine("Produto: " + nomes[i] + " | " + "Preço: R$" + precos[i]);
            }
        }
    }
}
