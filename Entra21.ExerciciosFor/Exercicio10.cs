using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            /*Solicite um número e apresente:
            Os 50 números antecessores pares;
            Os 50 números sucessores ímpares*/

            var numero = 0.00;

            Console.WriteLine("Informe um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 50; i++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
