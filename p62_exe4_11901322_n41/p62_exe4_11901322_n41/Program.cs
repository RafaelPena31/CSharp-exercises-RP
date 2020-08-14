using System;

namespace p62_exe4_11901322_n41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 nº41");
            int idade=0,i,soma=0;
            string nome = "",nomes="";

            for (i = 0; i <= 200; i++)
            {   
                Console.WriteLine("Digite o nome do atleta");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do atleta");
                idade = int.Parse(Console.ReadLine());
                soma += idade;
                if (idade > 21)
                {
                    nomes += nome + ", ";
                }
            }
            Console.WriteLine("A soma das idades é igual a: " + soma);
            Console.WriteLine("As pessoas com idade acima de 21 é igual a: " + nomes);
            Console.ReadKey();

        }
    }
}
