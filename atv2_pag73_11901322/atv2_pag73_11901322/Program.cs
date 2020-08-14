using System;

namespace atv2_pag73_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita");
            int[] num = new int[20];
            int indice = 0;

            Random aleatorio = new Random();

            for(indice = 0; indice < 20; indice++)
            {
                Console.WriteLine(indice);
                num[indice] = aleatorio.Next(10, 80);
            }

            for(indice = 0; indice < 20; indice++)
            {
                if (num[indice] >= 50)
                {
                    Console.WriteLine("Na posição " + indice + " do vetor esta armazenado o número: " + num[indice);
                }
            }
            Console.ReadKey();
        }
    }
}
