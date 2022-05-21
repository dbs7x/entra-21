using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            //Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade

            var quantidade = 9;
            var idades = new int [quantidade];
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Idade: ");
                idades [i] = Convert.ToInt32(Console.ReadLine());
            }

            var maiorIdade = int.MinValue;
            for (int i = 0;i < idades.Length;i++)
            {
                if (idades [i] > maiorIdade)
                {
                    maiorIdade = idades [i];
                }
            }

            Console.WriteLine("A pessoa com maior idade tem " + maiorIdade + " anos");
        }
    }
}
