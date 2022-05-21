using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            //Crie um vetor para guardar 16 números inteiros, preencha todas as posições com números e apresente a soma destes números

            var quantidade = 16;
            var numeros = new int[quantidade];
            var soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + numeros[i];
            }

            Console.Clear();
            Console.WriteLine("Soma: " + soma);
        }
    }
}
