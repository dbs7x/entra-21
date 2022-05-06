using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.WriteLine("Quantidade de carros que será cadastrada: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            int carrosCadastrados = 0;
            int anoCarro = 0;
            int totalAnoCarros = 0;
            double valorCarro = 0;
            double totalValorCarros = 0;
            int carrosLetraG = 0;
            int carrosLetraA = 0;

            while (carrosCadastrados < quantidadeCarros)
            {
                Console.WriteLine("Informe o modelo do carro: ");
                string modeloCarro = Console.ReadLine();

                if (modeloCarro.ToLower().StartsWith("g"))
                {
                    carrosLetraG = carrosLetraG + 1;
                }

                if (modeloCarro.ToLower().StartsWith("a"))
                {
                    carrosLetraA = carrosLetraA + 1;
                }

                Console.WriteLine("Informe o valor do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                totalValorCarros = totalValorCarros + valorCarro;

                Console.WriteLine("Informe o ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                totalAnoCarros = totalAnoCarros + anoCarro;

                carrosCadastrados = carrosCadastrados + 1;
            }

            Console.WriteLine("Média do ano dos carros: " + totalAnoCarros / quantidadeCarros);
            Console.WriteLine("Média do valor dos carros: " + valorCarro / quantidadeCarros);
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + carrosLetraG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + carrosLetraA);


        }
    }
}
