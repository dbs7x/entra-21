using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    internal class Temperatura
    {
        /*Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
        - Temperatura de origem
        - Temperatura de destino
        - Valor da temperatura

        Criar métodos:
        - Calcular Celsius para Kelvin
        - Calcular Celsius para Fahrenheit
        - Calcular Kelvin para Celsius
        - Calcular Kelvin para Fahrenheit
        - Calcular Fahrenheit para Celsius
        - Calcular Fahrenheit para Kelvin
        - Obter temperatura convertida
        Exemplo:
        Input:
        Temperatura origem: usuário digitou ‘Celcius’
        Temperatura destino: usuário digitou ‘Fahrenheit’
        Temperatura valor: usuário digitou 42.30;
        Processamento:
        Deve-se executar o método ‘Calcular Celsius para Fahrenheit’, pois de acordo com origem e
        destino deve executar este método.
        Output:
        Temperatura convertida: 108,14
        Obs.: Criar testes unitários, assim como, ExercicioTemperatura.*/

        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double TemperaturaValor;

        public void CalcularCelsiusParaKelvin()
        {
            TemperaturaValor = TemperaturaValor + 273.15;
            Console.WriteLine("Temperatura convertida de graus celsius para kelvin: " + TemperaturaValor);
        }

        public void CelsiusParaFahrenheit()
        {
            TemperaturaValor = TemperaturaValor * 1.8 + 32;
            Console.WriteLine("Temperatura convertida de graus celsius para fahrenheit: " + TemperaturaValor);
        }
        public void KelvinParaCelsius()
        {
            TemperaturaValor = TemperaturaValor - 273.15;
            Console.WriteLine("Temperatura convertida de graus kelvin para celsius: " + TemperaturaValor);
        }

        public void KelvinParaFahrenheit()
        {
            TemperaturaValor = 1.8 * (TemperaturaValor - 273.15) + 32;
            Console.WriteLine("Temperatura convertida de graus kelvin para fahrenheit: " + TemperaturaValor);
        }

        public void FahrenheitParaCelsius()
        {
            TemperaturaValor = (TemperaturaValor - 32) / 1.8;
            Console.WriteLine("Temperatura convertida de graus fahrenheit para celsius: " + TemperaturaValor);
        }

        public void FahrenheitParaKelvin()
        {
            TemperaturaValor = (TemperaturaValor + 459.67) * 5 / 9;
            Console.WriteLine("Temperatura convertida de graus fahrenheit para kelvin: " + TemperaturaValor);
        }

        public void Conversor()
        {
            if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "kelvin")
            {
                CalcularCelsiusParaKelvin();
            }

            else
            {
                Console.WriteLine("Temperatura de origem ou destina inválida");
            }
        }
    }
}
