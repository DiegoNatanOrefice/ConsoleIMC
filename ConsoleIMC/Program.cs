using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] imc = new double[5];
            int[] imcclassificacao = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Insira o nome da pessoa: ");
                nome[i] = Console.ReadLine();

                Console.Write("Insira o peso da pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());

                Console.Write("Insira a altura da pessoa (em metros): ");
                altura[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);

                Console.Clear();
            }

            for (int j = 0;j < 5;j++)
            {
                if (imc[j] <= 18.5)
                {
                    imcclassificacao[j] = 1;
                }

                else if (imc[j] <=24.9)
                {
                    imcclassificacao[j] = 2;
                }

                else if (imc[j] <= 29.9)
                {
                    imcclassificacao[j] = 3;
                }

                else if (imc[j] <= 34.9)
                {
                    imcclassificacao[j] = 4;
                }

                else if (imc[j] <= 39.9)
                {
                    imcclassificacao[j] = 5;
                }

                else if (imc[j] > 40)
                {
                    imcclassificacao[j] = 6;
                }

                else
                {
                    Console.Write("Erro");
                }
            }

            for(int k = 0; k < 5;k++)
            {
                Console.WriteLine("Nome: " + nome[k]);
                Console.WriteLine("Peso: " + peso[k]);
                Console.WriteLine("Altura: " + altura[k]);
                Console.WriteLine("IMC: " + imc[k]);

                if (imcclassificacao[k] == 1)
                {
                    Console.WriteLine("Classificação: Abaixo do peso");
                    Console.WriteLine();
                }
                
                else if (imcclassificacao[k] == 2)
                {
                    Console.WriteLine("Classificação: Peso ideal");
                    Console.WriteLine();
                }

                else if (imcclassificacao[k] == 3)
                {
                    Console.WriteLine("Classificação: Levemente acima do peso");
                    Console.WriteLine();
                }

                else if (imcclassificacao[k] == 4)
                {
                    Console.WriteLine("Classificação: Obesidade grau I");
                    Console.WriteLine();
                }

                else if (imcclassificacao[k] == 5)
                {
                    Console.WriteLine("Classificação: Obesidade grau II");
                    Console.WriteLine();
                }

                else if (imcclassificacao[k] == 6)
                {
                    Console.WriteLine("Classificação: Obesidade grau III");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Erro");
                }
            }

            Console.ReadKey();
        }
    }
}
