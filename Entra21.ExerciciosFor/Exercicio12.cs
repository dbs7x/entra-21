using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio12
    {
        public void Executar()
        {
            var codigoPedido = 0;
            var totalPedido = 0.00;
            var indice = 0;

            //Quantidade dos produtos escolhidos
            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizzas = 0;

            var mediaProdutos = 0.00;

            for (int i = 0; i != 16; i++)
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

                //Valor produtos
                var valorProduto1 = 29.50;
                var valorProduto2 = 2.00;
                var valorProduto3 = 29.23;

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
            }
            Console.WriteLine("Valor total do pedido: R$" + totalPedido);
            Console.WriteLine("Quantidade total de produtos do pedido: " + indice);
            Console.WriteLine("Quantidade de bolos escolhidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade de doces escolhidos: " + quantidadeDoces);
            Console.WriteLine("Quantidade de sanduíches escolhidos: " + quantidadeSanduiches);
            Console.WriteLine("Quantidade de pizzas escolhidas: " + quantidadePizzas);
            mediaProdutos = totalPedido / indice;
            Console.WriteLine("Média dos produtos do pedido: R$" + mediaProdutos);
        }
    }
}