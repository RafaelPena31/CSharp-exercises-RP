using System;

namespace atv2_pag73_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita");
            int[] num = new int[50];
            int indice = 0;
            int max = int.MinValue;

            Random aleatorio = new Random();

            for (indice = 0; indice < 50; indice++)
            {
                Console.WriteLine(indice);
                num[indice] = aleatorio.Next(10, 80);
            }

            for (indice = 0; indice < 50; indice++)
            {
                if (num[indice] > max)
                {
                    max = num[indice];
                }
            }

            Console.WriteLine("Maior valor armazenado no vetor: " + max);
            Console.ReadKey();
        }
    }
}
