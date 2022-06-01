using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests
{
    public class TemperaturaTests
    {
        //[Fact]
        //public void ValidarCelsiusParaKelvin()
        //{
        //    //Arrange
        //    var temperatura = new Temperatura();
        //    temperatura.TemperaturaOrigem = "celsius";
        //    temperatura.TemperaturaDestino = "kelvin";
        //    temperatura.TemperaturaValor = 30;

        //    //Act
        //    var calculoCelsiusParaKelvin = temperatura.ObterTemperaturaConvertida();

        //    //Assert
        //    calculoCelsiusParaKelvin.Should().Be(303.15);
        //}

        //[Fact]
        //public void ValidarCelsiusParaFahrenheit()
        //{
        //    //Arrange
        //    var temperatura = new Temperatura();
        //    temperatura.TemperaturaOrigem = "celsius";
        //    temperatura.TemperaturaDestino = "fahrenheit";
        //    temperatura.TemperaturaValor = 30;

        //    //Act
        //    var calculoCelsiusParaFahrenheit = temperatura.ObterTemperaturaConvertida();

        //    //Assert
        //    calculoCelsiusParaFahrenheit.Should().Be(86);
        //}
        [Theory]
        [InlineData("celsius", "kelvin", 30, 303.15)]

        public void ValidarTemperaturaConvertida(string temperaturaOrigem, string temperaturaDestino, double temperaturaValor, double temperaturaEsperada)
        {
            //Arrenge
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = temperaturaOrigem;
            temperatura.TemperaturaDestino = temperaturaDestino;
            temperatura.TemperaturaValor = temperaturaValor;

            //Act
            var calculoConversao = temperatura.ObterTemperaturaConvertida();

            //Assert
            calculoConversao.Should().Be(temperaturaEsperada);

        }

    }
}
