using System;

namespace exe3_pag67_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1");
            string nome = ""; 
            char sexo; double altura = 0, peso = 0, mediaM = 0, mediaP = 0; 
            int onOff = 1, nPessoas = 0, nMasculino = 0;
            do
            {
                nPessoas++;
                Console.WriteLine("Digite o nome do selecionado:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o sexo do selecionado: (M - Masculino, F - Feminino");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do selecionado:");
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso do selecionado:");
                peso = double.Parse(Console.ReadLine());
                switch (sexo)
                {
                    case 'M':
                        nMasculino++;
                        mediaM += altura;
                        break;
                    case 'F':
                        break;
                    default:
                        Console.WriteLine("Código digitado inválido!");
                        break;
                }
                if (peso <= 70 && peso >= 80)
                {
                    mediaP++;
                }
                Console.WriteLine("Digite 1 para continuar o cadastro ou digite 0 para finalizar:");
                onOff = int.Parse(Console.ReadLine());
            } while (onOff > 0);
            Console.WriteLine("O nº de pessoas selecionadas são: " + nPessoas);
            Console.WriteLine("A quantidade de pessoas que pesam entre 70 e 80 quilos: "+mediaP);
            Console.WriteLine("A porcentagem de pessoas que pesam entre 70 e 80 quilos é: " + mediaP*100/nPessoas);
            Console.WriteLine("A média de altura do homens: " + mediaM/nMasculino);
            Console.ReadKey();
        }
    }
}
