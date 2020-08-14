using System;

namespace monitoriaatv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1");
            int matricula, q_fechadas, q_abertas;
            string nome;
            double redacao, nota_final;
            Console.WriteLine("Digite a matrícula do aluno: ");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nº de questões abertas que o aluno acertou:");
            q_abertas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nº de questões fechadas que o aluno acertou:");
            q_fechadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a pontuação da redação:");
            redacao = double.Parse(Console.ReadLine());

            nota_final = q_fechadas*2 + q_abertas*3 + redacao;

            if (nota_final >= 160)
            {
                Console.WriteLine("O aluno: "+nome+" cuja matrícula é: "+matricula+" obteve a nota total no simulado de : "
                    +nota_final+" e teve a classificação da nota como excelente");
            } else if (nota_final >= 130)
            {
                Console.WriteLine("O aluno: " + nome + " cuja matrícula é: " + matricula + " obteve a nota total no simulado de : "
                    + nota_final + " e teve a classificação da nota como ótimo");
            } else if (nota_final >= 100)
            {
                Console.WriteLine("O aluno: " + nome + " cuja matrícula é: " + matricula + " obteve a nota total no simulado de : "
                    + nota_final + " e teve a classificação da nota como bom");
            } else if (nota_final >= 70)
            {
                Console.WriteLine("O aluno: " + nome + " cuja matrícula é: " + matricula + " obteve a nota total no simulado de : "
                    + nota_final + " e teve a classificação da nota como regular");
            } else
            {
                Console.WriteLine("O aluno: " + nome + " cuja matrícula é: " + matricula + " obteve a nota total no simulado de : "
                    + nota_final + " e teve a classificação da nota como insuficiente");
            }
            Console.ReadKey();

        }
    }
}
