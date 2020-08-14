using System;

namespace exe1_Pag57_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1");
            int onOff = 1, num = 0, media = 0, quant = 0;

            while (onOff != 0)
            {
                Console.WriteLine("Digite o número para adicionar a média:");
                num = int.Parse(Console.ReadLine());
                media += num;
                quant++;
                Console.WriteLine("Ativar média: (0 - desativa, 1 - ativa)");
                onOff = int.Parse(Console.ReadLine());
            }
            media /= quant;
            Console.WriteLine("A média é de: " + media);
            Console.ReadKey();
        }
    }
}
