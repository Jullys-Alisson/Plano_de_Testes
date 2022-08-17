using System;

namespace Calculadora_IMC
{
    public static class IMC_Calcular
    {
        public static double calcular(double Altura, double Peso)
        {
            double Imc = Peso / (Altura * Altura);
            return Imc;           
        }
    }    
}


/*using System;

using System.Collections.Generic;

using System.Text;

namespace Calculadora_IMC

{

    public static class IMC_Calcular

    {
        public static decimal calcular(double Peso, double Altura)
        {
            double Imc = Peso / (Altura * Altura);
            return (decimal)Imc;
        }
        public static string resposta(decimal valorImc)
        {
            string resultado = null;

            if (valorImc < 18.5m)
            {
                resultado = "Você está abaixo do peso ideal";
            }

            if (valorImc >= 18.5m && valorImc <= 24.9m)
            {
                resultado = "Parabéns — você está em seu peso normal!";
            }

            if (valorImc >= 25.0m && valorImc <= 29.9m)
            {
                resultado = "Você está acima de seu peso (sobrepeso)";
            }

            if (valorImc >= 30.0m && valorImc <= 34.9m)
            {
                resultado = "Obesidade grau I";
            }

            if (valorImc >= 35.0m && valorImc <= 39.9m)
            {
                resultado = "Obesidade grau II";
            }

            if (valorImc >= 40.0m)
            {
                resultado = "Obesidade grau III";
            }
            return resultado;
        }
    }
}*/