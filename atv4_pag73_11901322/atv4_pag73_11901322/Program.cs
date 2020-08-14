using System;
using System.Diagnostics.CodeAnalysis;

namespace atv2_pag73_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita");
            int[] num = new int[200];
            int[] position = new int[200];
            int indice = 0, soma = 0, max = int.MinValue, min = int.MaxValue, quantZero = 0, quantNegativo = 0, quantPosition = 0;
            string minTxt = "";
            double media = 0, percentual = 0;


            Random aleatorio = new Random();

            for (indice = 0; indice < 200; indice++)
            {
                num[indice] = aleatorio.Next(-300, 300);
                soma += num[indice];
                if(num[indice] > max)
                {
                    max = num[indice];
                }
                if(num[indice] < min)
                {
                    min = num[indice];
                    minTxt = "O menor número armazenado é: " + min + " e se encontra na posição: " + indice;
                }
                if(num[indice] == 0)
                {
                    quantZero++;
                }
                if(num[indice] < 0)
                {
                    quantNegativo++;
                }
                if(num[indice] >= 100 & num[indice] <= 200)
                {
                    position[quantPosition] = indice;
                    quantPosition++;
                }
            }
            media = soma / 200;
            if(quantZero != 0)
            {
                percentual = quantZero * 100 / 200;
            } else
            {
                percentual = 0;
            }

            Console.WriteLine("A soma dos números armazenados: "+soma);
            Console.WriteLine("O maior número armazenado: "+max);
            Console.WriteLine(minTxt);
            Console.WriteLine("A média de valores dos números armazenados são: "+media);
            Console.WriteLine("A quantidade de números 0 digitados: "+quantZero);
            Console.WriteLine("Percentual de números 0 digitados: "+percentual+"%");
            Console.WriteLine("Quantidade de números negativos digitados: "+quantNegativo);
            Console.WriteLine("As posições dos números entre 100 e 200: ");
            for(indice = 0; indice < quantPosition; indice++)
            {
                Console.WriteLine(position[indice]);
            }

            
            Console.ReadKey();
        }
    }
}
