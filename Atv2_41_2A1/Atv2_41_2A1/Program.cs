using System;

namespace Atv2_41_2A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 41 - 2A1");
            string placa;
            double velP=0, velX=0;
            Console.WriteLine("Digite a placa do veículo: ");
            placa = Console.ReadLine();
            Console.WriteLine("Digite a velocidade máxima permitida na via:");
            velP = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade alcançada pelo motorista na via:");
            velX = double.Parse(Console.ReadLine());
            if (velX <= velP)
            {
                Console.WriteLine("Você não cometeu nenhuma infração de trânsito. PLACA: "+placa+" - " +
                    "Velocidade alcançada: "+velX+ "Km/h - Velocidade máxima permitida: "+velP+ "Km/h");
            } else if (velX > velP && velX <= (velP+10))
            {
                Console.WriteLine("PLACA: "+placa+" - Velocidade alcançada: "+velX+"Km/h -> Velocidade máxima permitida: "+velP+ "Km/h | " +
                    "Você cometeu uma infração de trânsito. Valor da multa: "+ (127.5).ToString("C")+ " - Velocidade exedida: " + (velX - velP)+"Km/h");
            } else if((velP + 10) < velX && (velP + 30) >= velX)
            {
                Console.WriteLine("PLACA: " + placa + " - Velocidade: " + velX + "Km/h -> Velocidade máxima permitida: " + velP + " |Km/h " +
                    "Você cometeu uma infração de trânsito. Valor da multa: " +(127.5*1.2).ToString("C")
                    + " - Velocidade exedida: " + (velX - velP)+ "Km/h");
            } else 
            {
                Console.WriteLine("PLACA: " + placa + " - Velocidade: " + velX + "Km/h -> Velocidade máxima permitida: " + velP + "Km/h | " +
                    "Você cometeu uma infração de trânsito. Valor da multa: " + (127.5 * 1.5).ToString("C")+" |" +
                    " - Velocidade exedida: " + (velX - velP)+ "Km/h");
            }
        }
    }
}
