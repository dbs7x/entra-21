using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            var precoPeca = 0.00; 
            var nomePeca = "";
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Preço da peça: ");
                precoPeca = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nome da peça: ");
                nomePeca = Console.ReadLine();
            }
        }
    }
}
