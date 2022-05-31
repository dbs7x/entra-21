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
        [Fact]
        public void ValidarCelsiusParaKelvin()
        {
            //Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "celsius";
            temperatura.TemperaturaDestino = "kelvin";
            temperatura.TemperaturaValor = 30;

            //Act
            var calculoCelsiusParaKelvin = temperatura.CelsiusParaKelvin();

            //Assert
            calculoCelsiusParaKelvin.Should().Be(303.15);
        }
    }
}
