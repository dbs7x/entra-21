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
                var nomeValido = false;
                while (nomeValido == false)
                {
                    Console.WriteLine("Nome da peça: ");
                    nomePeca = Console.ReadLine();
                    if (nomePeca.Trim().Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite o nome da peça");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if ((nomePeca.Length < 3) || (nomePeca.Length > 20))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um nome com pelos 3 e no máximo 20 caracteres");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        nomeValido = true;
                    }

                }
                var precoValido = false;
                while (precoValido == false)
                {
                    try
                    {
                        Console.WriteLine("Preço da peça: ");
                        precoPeca = Convert.ToDouble(Console.ReadLine());
                        if (precoPeca < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Preço inválido, informe um número positivo");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            precoValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Preço inválido");
                    }
                }
            }
        }
    }
}
