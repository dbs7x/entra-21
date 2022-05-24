using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorComplementar
{
    internal class Exercicio02
    {
        public void Executar()
        {
            var numerosPares = new int[3];

            for (int i = 0; i < numerosPares.Length;)
            {
                var numero = 0;
                while (numero <= 0)
                {
                    Console.Write("Informe um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero <= 0)
                    {
                        Console.WriteLine("Número invalido. Informe um número maior ou igual a zero.");
                    }
                    else if (numero % 2 == 0)
                    {
                        numerosPares[i] = numero;
                        i++;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Os 10 números pares informados foram: ");
            for (int i = 0; i < numerosPares.Length; i++)
            {
                Console.WriteLine(numerosPares[i]);
            }
        }
    }
}
