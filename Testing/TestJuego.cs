using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Testing
{
    [TestClass]
    public class TestJuego
    {
        [TestMethod]
        public void EsEscalera_CuandoEsEscalera()
        {
            //Arrange
            int[] dados = {1,4,3,2,5};
            bool expected = true;
           
            //Act
            bool resultado = Juego.EsEscalera(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsEscalera_CuandoNoEsEscalera()
        {
            //Arrange
            int[] dados = { 1, 4, 3, 2, 6 };
            bool expected = false;

            //Act
            bool resultado = Juego.EsEscalera(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsFull_CuandoEsFull()
        {
            //Arrange
            int[] dados = { 4, 4, 3, 3, 4 };
            bool expected = true;

            //Act
            bool resultado = Juego.EsFull(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsFull_CuandoNoEsFull()
        {
            //Arrange
            int[] dados = { 4, 2, 3, 3, 4 };
            bool expected = false;

            //Act
            bool resultado = Juego.EsFull(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsPoker_CuandoEsPoker()
        {
            //Arrange
            int[] dados = { 3, 3, 4, 3, 3 };
            bool expected = true;

            //Act
            bool resultado = Juego.EsPoker(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsPoker_CuandoNoEsPoker()
        {
            //Arrange
            int[] dados = { 4, 2, 3, 3, 4 };
            bool expected = false;

            //Act
            bool resultado = Juego.EsPoker(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsGenerala_CuandoEsGenerala()
        {
            //Arrange
            int[] dados = { 2, 2, 2, 2, 2 };
            bool expected = true;

            //Act
            bool resultado = Juego.EsGenerala(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void EsGenerala_CuandoNoEsGenerala()
        {
            //Arrange
            int[] dados = { 1, 2, 3, 3, 4 };
            bool expected = false;

            //Act
            bool resultado = Juego.EsGenerala(dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void CantidadDadosIguales_CuandoHayTresIguales()
        {
            //Arrange
            int[] dados = { 3, 2, 3, 3, 4 };
            int expected = 3;

            //Act
            int resultado = Juego.CantidadDadosIguales(3, dados);

            //Assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void ObtenerNumeroMasRepitido_CuandoElMasRepetidoEsSeisConDosCoincidencias()
        {
            //Arrange
            int[] dados = { 6, 2, 6, 3, 4 };
            int[] dadosExcluidos = { 0, 0, 0, 0, 0 };
            int[] expected = {6, 2};

            //Act
            int[] resultado = Juego.ObtenerNumeroMasRepetido(dados, dadosExcluidos);

            //Assert
            CollectionAssert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void ObtenerNumeroMasRepitido_CuandoElMasRepetidoEsElUnicoNoExcluido()
        {
            //Arrange
            int[] dados = { 6, 2, 6, 3, 4 };
            int[] dadosExcluidos = { 6, 3, 4, 0, 0 };
            int[] expected = { 2, 1 };

            //Act
            int[] resultado = Juego.ObtenerNumeroMasRepetido(dados, dadosExcluidos);

            //Assert
            CollectionAssert.AreEqual(expected, resultado);
        }

    }
}
