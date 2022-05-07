using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            double numero = 0;
            int indice = 0;

            Console.WriteLine("Informe um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            while (indice < 1000)
            {
                indice = indice + 1;

                double resultado = numero * indice;
                Console.WriteLine(numero + " x " + indice + " = " + resultado);
            }
        }
    }
}
