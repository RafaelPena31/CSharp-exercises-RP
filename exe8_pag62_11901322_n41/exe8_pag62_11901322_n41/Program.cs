using System;

namespace exe8_pag62_11901322_n41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 - 11901322");
            int sexo = 0; double altura = 0, alturaM = int.MaxValue, alturaB = int.MinValue, mediaM = 0, mediaH = 0; int quantM = 0, quantH = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o código correspondente ao sexo => 1 - Masculino / 2 - Feminino:");
                sexo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura em Cm's:");
                altura = double.Parse(Console.ReadLine());
                switch (sexo)
                {
                    case 1:
                        quantH++;
                        if (altura > alturaB)
                        {
                            alturaB = altura;
                        }
                        if(altura < alturaM)
                        {
                            alturaM = altura;
                        }
                        mediaH += altura;
                        break;
                    case 2:
                        quantM++;
                        if (altura > alturaB)
                        {
                            alturaB = altura;
                        }
                        if (altura < alturaM)
                        {
                            alturaM = altura;
                        }
                        mediaM += altura;
                        break;
                    default: Console.WriteLine("Código inválido"); break;
                }
            }
            mediaH /= quantH;
            mediaM /= quantM;
            Console.WriteLine("A maior altura da turma: "+alturaB+"Cm");
            Console.WriteLine("A menor altura da turma: "+alturaM+"Cm");
            Console.WriteLine("A média de altura feminina: "+mediaM+"Cm");
            Console.WriteLine("A média de altura masculina: "+mediaH+"Cm");
            Console.ReadKey();
        }
    }
}
