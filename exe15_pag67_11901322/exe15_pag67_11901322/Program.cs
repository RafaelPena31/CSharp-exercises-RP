using System;

namespace exe15_pag67_11901322
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - 2A1");
            int codigo = 0, cont = 0;
            double salario = 0.0, maior_salario = double.MinValue, menor_salario = double.MaxValue, total_folha = 0.0, media_salarial = 0.0;

            for (cont = 0; cont <= 225; cont++)
            {
                Console.WriteLine("Digite o código do empregado: ");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o salário do empregado: ");
                salario = double.Parse(Console.ReadLine());

                if (salario > maior_salario)
                {
                    maior_salario = salario;
                }
                if (salario > menor_salario)
                {
                    menor_salario = salario;
                }

                total_folha += salario;
            }

            media_salarial = total_folha / 225;

            Console.WriteLine("O maior salário é de: " + maior_salario);
            Console.WriteLine("O menor salário é de: " + menor_salario);
            Console.WriteLine("O total da folha de pagamento da indústria é de: " + total_folha);
            Console.WriteLine("A media salarial dos empregados é de: " + media_salarial);

            Console.ReadKey();

        }
    }
}
