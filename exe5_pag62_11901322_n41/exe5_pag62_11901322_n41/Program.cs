using System;

namespace exe5_pag62_11901322_n41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 - 11901322");
            string nome = ""; double salario = 0, salarioB = int.MinValue, salarioM = int.MaxValue, porc = 0;
            for (int i = 0; i<200; i++)
            {
                Console.WriteLine("Digite o nome do empregado:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o salário:");
                salario = double.Parse(Console.ReadLine());
                if (salario < 500)
                {
                    porc++;
                }
                if (salario > salarioB)
                {
                    salarioB = salario;
                }
                if(salario < salarioM)
                {
                    salarioM = salario;
                }
                porc = (porc * 100) / 200;
            }
            Console.WriteLine("O maior salário: " + salarioB.ToString("C"));
            Console.WriteLine("O menor salário: " + salarioM.ToString("C"));
            Console.WriteLine("Porcentagem de salário menor de R$ 500,00: " + porc+"%");
            Console.ReadKey();
        }
    }
}
