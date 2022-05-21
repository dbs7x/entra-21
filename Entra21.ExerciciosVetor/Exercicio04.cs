﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            /*Crie um vetor para armazenar as notas de uma disciplina
            A disciplina deve conter 4 notas
            Solicite para o usuário o nome e as quatro notas, armazenando as notas em um vetor, realize a média destas notas e apresente*/

            var quantidade = 4;
            var notas = new double[quantidade];
            var soma = 0.00;
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma = soma + notas[i];
            }

            Console.Clear();
            var media = soma / notas.Length;
            Console.WriteLine("A nota média de " + nome + " é: " + media);
        }
    }
}
