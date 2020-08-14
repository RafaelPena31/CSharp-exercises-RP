using System;

namespace atvC_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita 2A1 - nº 41 (11901322)");
            double total;
            int depen;
            Console.WriteLine("Digite o salário do funcionário:");
            total = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de dependentes:");
            depen = int.Parse(Console.ReadLine());

            if (depen == 1)
            {
                if(total <= 1200)
                {
                    Console.WriteLine("O funcionário receberá 13% de aumento que equivale a: "
                        +(total*0.13).ToString("C")+" e receberá no total: "+(total*1.13).ToString("C"));
                } else if (total <= 3700)
                {
                    Console.WriteLine("O funcionário receberá 11% de aumento que equivale a: "
                        + (total * 0.11).ToString("C") + " e receberá no total: " + (total * 1.11).ToString("C"));
                } else
                {
                    Console.WriteLine("O valor do seu salário é de: " + total.ToString("C"));
                }
            }
            else
            {
                if (total <= 1200)
                {
                    Console.WriteLine("O funcionário receberá 15% de aumento que equivale a: "
                        + (total * 0.15).ToString("C") + " e receberá no total: " + (total * 1.15).ToString("C"));
                }
                else if (total <= 3700)
                {
                    Console.WriteLine("O funcionário receberá 14% de aumento que equivale a: "
                        + (total * 0.14).ToString("C") + " e receberá no total: " + (total * 1.14).ToString("C"));
                }
                else
                {
                    Console.WriteLine("O valor do seu salário é de: " + total.ToString("C"));
                }
            }
            Console.ReadKey();
        }
    }
}
