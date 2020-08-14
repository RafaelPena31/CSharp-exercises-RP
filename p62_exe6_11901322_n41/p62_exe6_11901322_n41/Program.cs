using System;

namespace p62_exe6_11901322_n41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1 nº 41");
            string nome; double i, hSexo=0, fSexo=0, maiorIdade=0, menorIdade=0, idade = 0; char sexo; 

            for (i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite o nome");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idade = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o caractér correspondente ao sexo: M - Masculino, F - Feminino");
                sexo = char.Parse(Console.ReadLine());
                switch (sexo)
                {
                    case 'M': hSexo++;
                        break;
                    case 'F': fSexo++;
                        break;
                    default: Console.WriteLine("Dados digitados inválidos");
                        break;
                }
                if (idade < 18)
                {
                    menorIdade++;
                }
                else
                {
                    maiorIdade++;
                }
            }
            idade = maiorIdade / (menorIdade + maiorIdade);
            Console.WriteLine("Nº de homens: " + hSexo);
            Console.WriteLine("Nº de mulheres: " + fSexo);
            Console.WriteLine("Nº de pessoas maiores de idade: " + maiorIdade);
            Console.WriteLine("Nº de pessoas menores de idade: " + menorIdade);
            Console.WriteLine("Porcentagem de pessoas maiores de idade: " + idade.ToString("P"));
            Console.ReadKey();
        }
    }
}
