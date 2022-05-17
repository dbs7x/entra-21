using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            //8. Solicite um número e apresentar a tabuada do mesmo até 1000
            var numero = 0;
            Console.WriteLine("Informe um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }
    }
}
