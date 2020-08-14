using System;

namespace atv13_pag74_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Pena");
            string[] candidatos = new string[10];
            int[] votos = new int[10];
            int indice = 0, max = int.MinValue;
            string vencedor = "";

            Random aleatorio = new Random();

            for (indice = 0; indice < 10; indice++)
            {
                candidatos[indice] = "candidato" + indice;
                votos[indice] = aleatorio.Next(10, 20);
                if(votos[indice] > max)
                {
                    max = votos[indice];
                    vencedor = "Candidato vencedor: " + candidatos[indice] + " - Nº de votos: " + max;
                }
            }

            for (indice = 0; indice < 10; indice++)
            {
                Console.WriteLine("Nome do candidato: " + candidatos[indice] + " - Nº de votos: " + votos[indice]);
            }
            Console.WriteLine(vencedor);
            Console.ReadKey();
        }
    }
}
