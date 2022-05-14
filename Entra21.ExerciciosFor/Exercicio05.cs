using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            var quantidadeCarros = 0;
            var modeloCarro = "";
            var valorCarro = 0.00;
            var anoCarro = 0;
            var mediaAnoCarros = 0;
            var mediaValorCarros = 0.00;
            var carrosLetraG = 0;
            var carrosLetraA = 0;

            for (int i = 0; i < quantidadeCarros; i++)
            {
                Console.WriteLine("Modelo:");
                modeloCarro = Console.ReadLine();
                Console.WriteLine("Valor:");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ano");
                anoCarro = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Média do ano dos carro: " + mediaAnoCarros);
            Console.WriteLine("Média do valor dos carros: " + valorCarro); ;
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + carrosLetraG);
        }
    }
}
