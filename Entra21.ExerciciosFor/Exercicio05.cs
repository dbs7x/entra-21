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
            /*Faça um programa que solicite a quantidade de carros que o usuário deseja
            cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
            atinja a quantidade de carros para cadastro.
            Apresente ao final:
            ● Média do ano dos carros;
            ● Média do valor dos carros;
            ● Quantidade de carros que começam com a letra G;
            ● Quantidade de carros que começam com a letra A.*/

            var quantidadeCarros = 0;
            var anoTotalCarros = 0;
            var valorTotalCarros = 0.00;
            var carrosLetraG = 0;
            var carrosLetraA = 0;
            var mediaAnoCarros = 0;
            var mediaValorCarros = 0.00;

            Console.WriteLine("Quantidade de carros que deseja cadastrar: ");
            quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidadeCarros; i++)
            {
                Console.WriteLine("Modelo: ");
                var modeloCarro = Console.ReadLine().ToLower().Trim();
                if (modeloCarro.StartsWith("g"))
                {
                    carrosLetraG = carrosLetraG + 1;
                }
                if (modeloCarro.StartsWith("a"))
                {
                    carrosLetraA = carrosLetraA + 1;
                }
                Console.WriteLine("Valor: R$");
                var valorCarro = Convert.ToDouble(Console.ReadLine());
                valorTotalCarros = valorTotalCarros + valorCarro;
                Console.WriteLine("Ano: ");
                var anoCarro = Convert.ToInt32(Console.ReadLine());
                anoTotalCarros = anoTotalCarros + anoCarro;
            }
            mediaAnoCarros = anoTotalCarros / quantidadeCarros;
            mediaValorCarros = valorTotalCarros / quantidadeCarros;
            Console.WriteLine("Média do ano dos carros: " + mediaAnoCarros);
            Console.WriteLine("Média do valor dos carros: " + mediaValorCarros); ;
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + carrosLetraG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + carrosLetraA);
        }
    }
}
