using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coffeeBeans = 10;
            int water = 500;
            bool isPowerOn = false;

            while (true)
            {
                Console.WriteLine("Bem-vindo à máquina de café!");

                Console.WriteLine("1. Ligar/Desligar");
                Console.WriteLine("2. Fazer café");
                Console.WriteLine("3. Verificar níveis");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opção: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        isPowerOn = !isPowerOn;
                        Console.WriteLine("Máquina de café: " + (isPowerOn ? "Ligada" : "Desligada"));
                        break;

                    case 2:
                        if (!isPowerOn)
                        {
                            Console.WriteLine("A máquina de café está desligada. Ligue-a primeiro.");
                        }
                        else
                        {
                            Console.Write("Insira o valor que deseja depositar: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Opções de café:");
                            Console.WriteLine("1. Café expresso - R$ 3,00");
                            Console.WriteLine("2. Capuccino - R$ 4,50");
                            Console.WriteLine("3. Mocaccino - R$ 6,00");
                            Console.WriteLine("4. Água quente - R$ 1,00");

                            Console.Write("Escolha uma opção de café: ");
                            int coffeeOption = Convert.ToInt32(Console.ReadLine());

                            decimal coffeePrice = 0;
                            switch (coffeeOption)
                            {
                                case 1:
                                    coffeePrice = 3.00m;
                                    break;

                                case 2:
                                    coffeePrice = 4.50m;
                                    break;

                                case 3:
                                    coffeePrice = 6.00m;
                                    break;

                                case 4:
                                    coffeePrice = 1.00m;
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente.");
                                    break;
                            }

                            if (coffeePrice > amount)
                            {
                                Console.WriteLine("Valor insuficiente para a compra. Insira um valor maior.");
                            }
                            else if (coffeeBeans < 1 || water < 50)
                            {
                                Console.WriteLine("Não há café suficiente ou água suficiente. Verifique os níveis.");
                            }
                            else
                            {
                                coffeeBeans--;
                                water -= 50;
                                decimal change = amount - coffeePrice;
                                Console.WriteLine("Café pronto! Aproveite.");
                                Console.WriteLine("Troco: R$ " + change);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Níveis:");
                        Console.WriteLine("Café: " + coffeeBeans + " unidades");
                        Console.WriteLine("Água: " + water + " ml");
                        break;

                    case 4:
                        Console.WriteLine("Até logo!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");

                }
            }
        }
    }
}
