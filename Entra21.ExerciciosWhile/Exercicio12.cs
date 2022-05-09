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
            double valor1 = 29.5;
            double valor2 = 2;
            double valor3 = 29.23;

            while (codigo !=)
            Console.WriteLine(@"Faça seu pedido, informe o código:
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
-----------------------------------------------------------------------------");
            int pedido = Convert.ToInt32(Console.ReadLine());
            double totalPedido = 0;
            double quantidadeProdutosConsumidos = 0;

            if (pedido == 1)
            {
                totalPedido = totalPedido + valor1;
            }
            if (pedido == 2)
            {
                totalPedido = totalPedido + valor2;
            }
            if (pedido == 3)
            {
                totalPedido = totalPedido + valor3;
            }
            quantidadeProdutosConsumidos = quantidadeProdutosConsumidos + 1;
        }
    }
}
