﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            //Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos

            var quantidade = 5;
            var pesos = new double [quantidade];
            var soma = 0.00;
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine("Peso: ");
                pesos [i] = Convert.ToDouble(Console.ReadLine());
                soma = soma + pesos [i];
            }
            var media = soma / pesos.Length;
            Console.Clear();
            Console.WriteLine("Soma total dos pesos: " + soma);
            Console.WriteLine("Média dos pesos: " + media);
        }
    }
}
