using System;
using System.Globalization;

namespace Criar_Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            conta x ;
            

            Console.Write(" Digite o numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write(" Digite o nome do Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 's')
            {
                Console.Write("Digite o valor inicial:");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new conta(numero, nome, valorInicial);
            }
            else
            {
                x = new conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta Criada: ");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine("Digite um valor para deposito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(dep);
            Console.WriteLine();
            Console.WriteLine("Conta Atualizada: ");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite o valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saq);
            Console.WriteLine();
            Console.WriteLine("Conta Atualizada: ");
            Console.WriteLine(x);

            Console.ReadLine();

        }
    }
}
