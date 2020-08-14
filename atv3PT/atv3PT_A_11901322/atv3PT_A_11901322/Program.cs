using System;
using System.Security.Cryptography;

namespace atv3PT_A_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 - nº41 (11901322)");
            double num;
            char type;
            Console.WriteLine("Digite o caractér correspondente ao combustível utilizado: (G) - Gasolina / (E) - Etanol");
            type = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de litros vendidos:");
            num = double.Parse(Console.ReadLine());
            switch (type)
            {
                case 'G':
                    if (num <= 20)
                    {
                        num = (num * 4.397);
                        Console.WriteLine("O cliente receberá o desconto de: "+
                            (num*0.05).ToString("C")+" e pagará o valor total de: "+(num*0.95).ToString("C"));
                    }
                    else
                    { 
                        num = (num * 4.397);
                        Console.WriteLine("O cliente receberá o desconto de: " +
                            (num * 0.09).ToString("C") + " e pagará o valor total de: " + (num*0.91).ToString("C"));
                    }
                    break;
                case 'E':
                    if (num <= 20)
                    {
                        num = (num * 2.885);
                        Console.WriteLine("O cliente receberá o desconto de: " +
                            (num * 0.03).ToString("C") + " e pagará o valor total de: " + (num * 0.97).ToString("C"));
                    }
            
                    else
                    {
                        num = (num * 2.885);
                        Console.WriteLine("O cliente receberá o desconto de: " +
                            (num * 0.06).ToString("C") + " e pagará o valor total de: " + (num * 0.94).ToString("C"));
                    }
                    break;
                default:
                    Console.WriteLine("Você digitou o caractér errado, por favor preencha novamente.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
