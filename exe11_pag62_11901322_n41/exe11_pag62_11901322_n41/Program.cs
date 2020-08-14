using System;

namespace exe11_pag62_11901322_n41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 - 11901322");
            int num, i; string list="";
            Console.WriteLine("Digite o número a ser dividido:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    list = list + i + ", ";
                }
            }
            list = list + num;
            Console.WriteLine("Os divisores são: "+list);
        }
    }
}
