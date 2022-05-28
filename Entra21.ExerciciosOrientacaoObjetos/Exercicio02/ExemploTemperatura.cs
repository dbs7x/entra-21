using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    internal class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "celsius";
            temperatura.TemperaturaDestino = "kelvin";
            temperatura.TemperaturaValor = 30;

            temperatura.Conversor();
        }
    }
}
