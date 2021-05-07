using System;

namespace Calculadora
{
    class Calculadora
    {
        public static double Calcular(double valor1, char operador, double valor2)
        {
            switch (operador)
            {
                case '+':
                    return valor1 + valor2;
                case '-':
                    return valor1 - valor2;
                case '*':
                    return valor1 * valor2;
                case '/':
                    return valor1 / valor2;
                default:
                    return 0.0;
            }
        }
    }
}