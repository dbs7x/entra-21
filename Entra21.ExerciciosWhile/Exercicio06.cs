using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nomeProduto = " ";
            double valorProduto = 0;
            double quantidadeProduto = 0;
            double total = 0;

            while (nomeProduto != "sair")
            {
                Console.WriteLine("Nome do produto: ");
                nomeProduto = Console.ReadLine();
                if (nomeProduto != "sair")
                {
                    Console.WriteLine("Valor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade do produto: ");
                    quantidadeProduto = Convert.ToDouble(Console.ReadLine());

                    total = total + (valorProduto * quantidadeProduto);
                }
            }
            double totalComDesconto = total - (total * 0.05);
            Console.WriteLine("O valor total da compra com 5% de desconto é de: R$" + totalComDesconto);
        }
    }
}
