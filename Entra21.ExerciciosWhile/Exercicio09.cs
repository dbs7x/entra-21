using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            double numero = 0;
            double calculo = 0;

            Console.WriteLine("Informe um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            double indice = numero;
            double fatorial = 0;

            while (indice > 1)
            {
                calculo = numero * indice;
                Console.WriteLine("Número: " + numero + " Indice: " + indice);
                indice = indice - 1;
                Console.WriteLine("Indice: " + indice);
                fatorial = fatorial + calculo;
                Console.WriteLine("Fatorial: " + fatorial);
            }
        }
    }
}
