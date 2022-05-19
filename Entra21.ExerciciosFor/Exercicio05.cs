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

            while ((quantidadeCarros <= 0) || (quantidadeCarros > 100))
            {
                try
                {
                    Console.WriteLine("Quantidade de carros que deseja cadastrar: ");
                    quantidadeCarros = Convert.ToInt32(Console.ReadLine());
                    if (quantidadeCarros < 0)
                    {
                        Console.WriteLine("A quantidade de carros deve ser maior que zero");
                    }
                    else if (quantidadeCarros > 100)
                    {
                        Console.WriteLine("A quantidade de carros deve ser menor que 100");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O número informado deve ser um número inteiro");
                }
            }

            for (int i = 0; i < quantidadeCarros; i++)
            {
                var modeloCarro = "";
                while ((modeloCarro.Trim().Length <= 0) || (modeloCarro.Trim().Length >= 2))
                {
                    Console.WriteLine("Modelo: ");
                    modeloCarro = Console.ReadLine().ToLower().Trim();
                    if (modeloCarro.Trim().Length <= 0)
                    {
                        Console.WriteLine("Informe o modelo do carro");
                    }
                    else if (modeloCarro.Trim().Length >= 2)
                    {
                        Console.WriteLine("O modelo do carro deve conter menos que 100 caracteres");
                    }
                }
                if (modeloCarro.StartsWith("g"))
                {
                    carrosLetraG++;
                }
                if (modeloCarro.StartsWith("a"))
                {
                        carrosLetraA++;
                }

                var valorCarro = 0.00;
                while (valorCarro <= 0)
                {
                    try
                    {
                        Console.WriteLine("Valor: R$");
                        valorCarro = Convert.ToDouble(Console.ReadLine());
                        if (valorCarro <= 0)
                        {
                            Console.WriteLine("Valor inválido, informe um número positivo");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                valorTotalCarros = valorTotalCarros + valorCarro;

                var anoCarro = 0;
                Console.WriteLine("Ano: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                anoTotalCarros = anoTotalCarros + anoCarro;
            }
            var mediaAnoCarros = anoTotalCarros / quantidadeCarros;
            var mediaValorCarros = valorTotalCarros / quantidadeCarros;
            Console.WriteLine("Média do ano dos carros: " + mediaAnoCarros);
            Console.WriteLine("Média do valor dos carros: " + mediaValorCarros); ;
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + carrosLetraG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + carrosLetraA);
        }
    }
}
