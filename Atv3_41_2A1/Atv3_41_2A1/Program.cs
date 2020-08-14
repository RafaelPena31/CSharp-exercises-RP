using System;

namespace Atv3_41_2A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita 41 - 2A1");
            string cod;
            char sexo;
            int tempo= 0;
            double salario = 0;
            Console.WriteLine("Digite o código de funcionário:");
            cod = Console.ReadLine();
            Console.WriteLine("Digite o sexo do funcionário -> M para masculino e F para feminino (digite somente em MAIÚSCULO):");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo de trabalho em anos:");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário do funcionário:");
            salario = double.Parse(Console.ReadLine());
            switch (sexo)
            {
                case 'M':
                    if (tempo < 15)
                    {
                        salario = salario * 0.2;
                    } else
                    {
                        salario = salario * 0.25;
                    }Console.WriteLine("O valor bônus de salário que o funcionário referente ao código: "+cod+
                        " receberá é: "+salario.ToString("C"));
                    break;
                case 'F':
                    if (tempo < 10)
                    {
                        salario = salario * 0.25;
                    } else
                    {
                        salario = salario * 0.3;
                    }
                   
                   
                   
                   Console.WriteLine("O valor bônus de salário que o funcionário referente ao código: "+cod+
                        " receberá é: "+salario.ToString("C"));
                    break;
                default: Console.WriteLine("Valor referente ao sexo do funcionário inválido.");
                    break;
            }
        }
    }
}
