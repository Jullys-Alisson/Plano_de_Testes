using Calculadora_IMC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IMC_Teste_MStest
{
    [TestClass]
    public class IMC_MStest
    {
        [TestMethod]
        public void MetodoTest1()
        {
            //Preparação (ARRANGE)
            double Altura = 1;
            double Peso = 1;
            double Total = 2;

            //Ação (ACT)
            var resultado = IMC_Calcular.calcular(Peso, Altura);

            //Verificação (ASSERT)
            Assert.AreEqual(Total, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 5, 5)]
        [DataRow(5, 5, 5)]
        [DataRow(25, 4, 8)]
        public void MetodoTest2(double Altura, double Peso, double Total)
        {
            //Ação (ACT)
            var resultado = IMC_Calcular.calcular(Altura, Peso);

            //Verificação (ASSERT)
            Assert.AreEqual(Total, resultado);
        }
    }
}