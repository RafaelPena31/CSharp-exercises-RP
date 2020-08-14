using System;

namespace atv2_3PT_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita 2A1 - nº 41 (11901322)");
            string nome, cpf;
            double total;
            int num;
            char type;
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF sem hífen:");
            cpf = Console.ReadLine();
            Console.WriteLine("Valor do produto:");
            total = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de parcelas (se for a vista digite 1):");
            num = int.Parse(Console.ReadLine());
            if (total > 500)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("O cliente: " + nome + " cujo o CPF é: " + cpf +
                    " pagará no total " + total.ToString("C") + " em " + num + " parcela(s) - (cada parcela custará: " + (total / num).ToString("C"));
                        break;
                    case 2:
                        Console.WriteLine("O cliente: " + nome + " cujo o CPF é: " + cpf +
                    " pagará no total " + (total*1.015).ToString("C") + " em " + num + " parcela(s) - (cada parcela custará: " 
                    + ((total*1.015) / num).ToString("C")+" e terá o juros de "+(total*0.015).ToString("C"));
                        break;
                    case 3:
                        Console.WriteLine("O cliente: " + nome + " cujo o CPF é: " + cpf +
                    " pagará no total " + (total * 1.02).ToString("C") + " em " + num + " parcela(s) - (cada parcela custará: " + ((total * 1.02) / num).ToString("C")
                    + " e terá o juros de " + (total * 0.02).ToString("C"));
                        break;
                    case 4:
                        Console.WriteLine("O cliente: " + nome + " cujo o CPF é: " + cpf +
                    " pagará no total " + (total * 1.025).ToString("C") + " em " + num + " parcela(s) - (cada parcela custará: " + ((total * 1.025) / num).ToString("C")
                    + " e terá o juros de " + (total * 0.025).ToString("C"));
                        break;
                    default:
                        Console.WriteLine("Valor inserido inválido");
                        break;
                }
            }
            else
            {
                Console.WriteLine("O cliente: " + nome + " cujo o CPF é: " + cpf +
                    " pagará no total " + total.ToString("C")+" em "+num+" parcela(s) - (cada parcela custará: "+(total/num).ToString("C"));
            }

            Console.ReadKey();
        }
    }
}
