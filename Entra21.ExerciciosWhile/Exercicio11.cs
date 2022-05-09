using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            Console.WriteLine("Informe o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            int opcao = 0;

            while (opcao != 5)
            {
                double calculo = 0;

                Console.WriteLine("Escolha uma opção:\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    calculo = numero1 + numero2;
                    Console.WriteLine("O resultado da operação é: " + calculo);
                }
                else if (opcao == 2)
                {
                    calculo = numero1 - numero2;
                    Console.WriteLine("O resultado da operação é: " + calculo);
                }
                else if (opcao == 3)
                {
                    calculo = numero1 * numero2;
                    Console.WriteLine("O resultado da operação é: " + calculo);
                }
                else if (opcao == 4)
                {
                    calculo = numero1 / numero2;
                    Console.WriteLine("O resultado da operação é: " + calculo);
                }
                else if (opcao > 5)
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
        }
    }
}
