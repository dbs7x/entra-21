using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        public void Executar()
        {
            int codigoPedido = 0;

            double totalPedido = 0;
            double quantidadeProdutosConsumidos = 0;

            //Valor produtos
            double valorProduto1 = 29.5;
            double valorProduto2 = 2;
            double valorProduto3 = 29.23;

            //Quantidade dos produtos escolhidos
            int quantidadeBolos = 0;
            int quantidadeDoces = 0;
            int quantidadeSanduiches = 0;
            int quantidadePizzas = 0;

            while (codigoPedido != 16)
            {
                Console.WriteLine(@"
-----------------------------------------------------------------------------
|Código | Tipo       | Nome                                        | Valor  |
-----------------------------------------------------------------------------
|1      | Bolos      | Bolo Brigadeiro                             | R$29,50|
|2      | Bolos      | Bolo Floresta Negra                         | R$2,00 | 
|3      | Bolos      | Bolo Leite com Nutella                      | R$29,23|
|4      | Bolos      | Bolo Mousse de Chocolate                    | R$7,10 |
|5      | Bolos      | Bolo Nega Maluca                            | R$19,33|
|6      | Doces      | Bomba de Creme                              | R$17,71|
|7      | Doces      | Bomba de Morango                            | R$4,82 |
|8      | Sanduíches | Filé-Mignon com fritas e cheddar            | R$21,16|
|9      | Sanduíches | Hambúrguer com queijos, champignon e rúcula | R$12,70|
|10     | Sanduíches | Provolone com salame                        | R$19,70|
|11     | Sanduíches | Vegetariano de berinjela                    | R$28,22|
|12     | Pizzas     | Calabresa                                   | R$8,98 |
|13     | Pizzas     | Napolitana                                  | R$0,42 |
|14     | Pizzas     | Peruana                                     | R$18,36|
|15     | Pizzas     | Portuguesa                                  | R$27,50|
|16     |            | Sair                                                 |
-----------------------------------------------------------------------------
Faça seu pedido, informe o código: ");
                codigoPedido = Convert.ToInt32(Console.ReadLine());

                if (codigoPedido == 1)
                {
                    totalPedido = totalPedido + valorProduto1;
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if (codigoPedido == 2)
                {
                    totalPedido = totalPedido + valorProduto2;
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if (codigoPedido == 3)
                {
                    totalPedido = totalPedido + valorProduto3;
                    quantidadeBolos = quantidadeBolos + 1;
                }
                quantidadeProdutosConsumidos = quantidadeProdutosConsumidos + 1;

                Console.WriteLine("Valor total do pedido: R$" + totalPedido);
                Console.WriteLine("Quantidade total de produtos do pedido: " + quantidadeProdutosConsumidos);
                Console.WriteLine("Quantidade de bolos escolhidos: " + quantidadeBolos);
                Console.WriteLine("Quantidade de doces escolhidos: " + quantidadeDoces);
                Console.WriteLine("Quantidade de sanduíches escolhidos: " + quantidadeSanduiches);
                Console.WriteLine("Quantidade de pizzas escolhidas: " + quantidadePizzas);
            }
        }
    }
}
