using System;

namespace p62_exe10_11901322_n41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 nº41");
            double nn, i, total;
            Console.WriteLine("Escreva o número para receber o fatorial:");
            nn = double.Parse(Console.ReadLine());
            total = nn;
            for (i = 1; i <= nn; i++)
            {
                total = total * i;
                Console.WriteLine("teste");
            }
            Console.WriteLine("O seu fatorial é igual a: " + total);
            Console.ReadKey();
        }
    }
}
