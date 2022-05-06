using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            double quantidade = 0;
            double total = 0;

            while (quantidade < 5)

            Console.WriteLine("Nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            quantidade = Convert.ToDouble(Console.ReadLine());


        }

    }
}
