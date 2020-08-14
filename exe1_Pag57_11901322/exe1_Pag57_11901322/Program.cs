using System;

namespace exe1_Pag57_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1");
            int presenca = 0, aluno = 0, ausenteM = 0, ausenteF = 0; char sexo = 'x'; 
            
            while (presenca != 2)
            {
                Console.WriteLine("Digite o sexo do aluno: (M - Masculino, F - Feminino");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o código de presença: (0 - presente, 1 - ausente)");
                presenca = int.Parse(Console.ReadLine());
                switch (sexo)
                {
                    case 'M':
                        aluno++;
                        if(presenca == 1)
                        {
                            ausenteM++;
                        }
                        break;
                    case 'F':
                        aluno++;
                        if (presenca == 1)
                        {
                            ausenteF++;
                        }
                        break;
                    default: Console.WriteLine("Código inválido");
                        break;
                }
            }
            Console.WriteLine("A quantidade de alunos são: " + aluno);
            Console.WriteLine("O número de mulheres ausentes são: " + ausenteF);
            Console.WriteLine("O número de homens ausentes são: " + ausenteM);
            Console.ReadKey();
        }
    }
}
