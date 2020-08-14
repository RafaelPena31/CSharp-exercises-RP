using System;

namespace Atv1_41_2a1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita 2A1 - 41");
            string matricula, nome;
            double redacao=0,quantF=0,quantA=0,soma=0;
            Console.WriteLine("Escreva a matrícula do aluno:");
            matricula = Console.ReadLine();
            Console.WriteLine("Escreva o nome do aluno:");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva a pontuação da redação:");
            redacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a pontuação de questões abertas:");
            quantA = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a pontuação de questões fechadas:");
            quantF = double.Parse(Console.ReadLine());
            soma = (quantA * 3)+(quantF*2)+redacao;
            if(soma <= 160)
            {
                Console.WriteLine("Nota final: "+soma+". O aluno está com a classificação da nota *excelente*.");
            } else if (soma >= 130)
            {
                Console.WriteLine("Nota final: " + soma + ". O aluno está com a classificação da nota *ótima*.");
            } else if(soma >= 100)
            {
                Console.WriteLine("Nota final: " + soma + ". O aluno está com a classificação da nota *bom*.");
            } else if (soma >= 70)
            {
                Console.WriteLine("Nota final: " + soma + ". O aluno está com a classificação da nota *regular*.");
            } else
            {
                Console.WriteLine("Nota final: " + soma + ". O aluno está com a classificação da nota *Insuficiente*.");
            }
        }
    }
}
