using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;
            while (indice <= 13)
            {
                Console.WriteLine("Preço da peça: ");
                double preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nome da peça: ");
                string nome = Console.ReadLine();
                indice = indice + 1;
            }
        }
    }
}
