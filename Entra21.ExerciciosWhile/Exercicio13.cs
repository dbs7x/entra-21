using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            //Variáveis de informações solicitadas
            string nome = "";
            int idade = 0;
            double peso = 0;
            string sexo = "";
            double altura = 0;
            int golsMarcados = 0;
            int cartoesAmarelos = 0;
            int cartoesVermelhos = 0;

            int quantidadeJogadores = 0;

            //Variáveis estatísticas
            double menorPeso = 9999;
            double maiorAltura = 0;

            while (quantidadeJogadores <= 22)
            {
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Sexo: ");
                sexo = Console.ReadLine();

                Console.WriteLine("Altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade de gols marcados: ");
                golsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de cartões amarelos recebidos: ");
                cartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de cartões vermelhos recebidos: ");
                cartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                //Jogador com menor peso
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }

                //Jogador com maior altura
                else if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }

                else if ()
                {

                }

                //Jogador com maior nome

            }
        }
    }
}
