using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            bool isSair = false;
            try
            {
                while (!isSair)
                {
                    string entrada = Console.ReadLine();
                    if (entrada == "SAIR" || entrada == "sair")
                    {
                        isSair = true;
                    }
                    else
                    {
                        string[] operacao = entrada.Split(' ');
                        double valor1 = double.Parse(operacao[0], CultureInfo.InvariantCulture);
                        char operador = char.Parse(operacao[1]);
                        double valor2 = double.Parse(operacao[2], CultureInfo.InvariantCulture);

                        //depois criar uma classe calculadora e criar os métodos de cada operação

                        if (operador == '/' && valor2 == 0)
                        {
                            Console.WriteLine("Não é possível fazer divisão por zero");
                        }
                        else if (!(operador == '+' || operador == '-' || operador == '*' || operador == '/'))
                        {
                            Console.WriteLine("Entrada inválida, tente novamente");
                        }
                        else
                        {
                            double resultado = Calculadora.Calcular(valor1, operador, valor2);

                            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada inválida, tente novamente");
            }
            finally
            {
                Console.WriteLine("Obrigado por usar a calculadora.");
            }
        }

        static void Header()
        {

            Console.WriteLine(" --------------------- CALCULADORA ---------------------");
            Console.WriteLine("           Digite a operação no formato: ");
            Console.WriteLine("            número  operador  número    ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("        Para sair digite SAIR ou sair ");
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}