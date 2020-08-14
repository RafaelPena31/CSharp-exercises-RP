using System;

namespace exe1_Pag57_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1");
            int nPecas = 0, totalPecas = 0, nCartao = 1,  quantM = 0, quantF = 0;
            double totalFolha = 0, salarioTempo = 0, salarioM = int.MinValue, mediaPecasM = 0, mediaPecasF = 0;
            char sexo;
            string salarios = "", stringSalarioM = "";

            while(nCartao != 0)
            {
                Console.WriteLine("Digite o número do cartão:");
                nCartao = int.Parse(Console.ReadLine());
                if (nCartao != 0)
                {
                    Console.WriteLine("Digite o número de peças produzidas:");
                    nPecas = int.Parse(Console.ReadLine());
                    totalPecas += nPecas;
                    Console.WriteLine("Digite o sexo:");
                    sexo = char.Parse(Console.ReadLine());

                    switch (sexo)
                    {
                        case 'F':
                            quantF++;
                            mediaPecasF += nPecas;
                            break;
                        case 'M':
                            quantM++;
                            mediaPecasM += nPecas;
                            break;
                        default: Console.WriteLine("Sexo não correspondente");
                            break;
                    }
                    if (nPecas <= 30)
                    {
                        salarioTempo = 1045;
                    }
                    else if (nPecas > 30 && nPecas < 36)
                    {
                        nPecas -= 30;
                        salarioTempo = 1045 + (nPecas * (1045 * 0.03));
                    }
                    else if (nPecas > 35)
                    {
                        nPecas -= 30;
                        salarioTempo = 1045 + (nPecas * (1045 * 0.05));
                    }
                    totalFolha += salarioTempo;
                    salarios += "Nº do cartão: " + nCartao + " - salário: " + salarioTempo.ToString("C") + " / ";
                    if(salarioTempo > salarioM) 
                    {
                        salarioM = salarioTempo;
                        stringSalarioM = "Nº do cartão: " + nCartao + " - sexo: " + sexo + " - salário: " + salarioM.ToString("c");
                    }
                }
            }
            mediaPecasM /= quantM;
            mediaPecasF /= quantF;

            Console.WriteLine("Salários dos operários: " + salarios);
            Console.WriteLine("O total da folha de pagamento é: " + totalFolha.ToString("C"));
            Console.WriteLine("O número total de peças: " + totalPecas);
            Console.WriteLine("A média de peças fabricadas pelos homens: " + mediaPecasM);
            Console.WriteLine("A média de peças fabricadas pelas mulheres: " + mediaPecasF);
            Console.WriteLine("Maior salário: " + stringSalarioM);
            
            Console.ReadKey();
        }
    }
}
