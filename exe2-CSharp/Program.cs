using System;
namespace exe2_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1:");

            int qntCliente = 26;

            double precoUnidadeSorvete = 1.50;
            double precoUnidadeDesconto = 1.25;

            int qntDesconto = 25;

            if (qntCliente >= qntDesconto)
            {
                double precoTotal = precoUnidadeDesconto * qntCliente;
                Console.WriteLine("O valor total com desconto é de: " + precoTotal);
            } else
            {
                double precoTotal = precoUnidadeSorvete * qntCliente;
                Console.WriteLine("O valor total é de: " + precoTotal);
            }



            Console.WriteLine("\nExercício 2:");

            int valor = 5;

            if (valor > 10)
            {
                int valorTotal = valor + 10 * 2;
                Console.WriteLine("O valor + 10 * 2 é igual à: " + valorTotal);
            } else
            {
                int valorTotal = valor + 9 * 3 - 8;
                Console.WriteLine("O valor + 9 * 3 - 8 é igual à: " + valorTotal);
            }



            Console.WriteLine("\nExercício 3:");

            int numero = -1;
            if (numero >= 0)
            {
                Console.WriteLine("O valor de: " + numero + " é um valor Positivo");
            } else if (numero < 0)
            {
                Console.WriteLine("O valor de: " + numero + " é um valor Negativo");
            }



            Console.WriteLine("\nExercício 4:");

            int variavel1 = 2;
            int variavel2 = 1;

            if (variavel1 > variavel2)
            {
                Console.WriteLine("A variável 1: " + variavel1 + " é maior que a variável 2: " + variavel2);
            } else if (variavel2 > variavel1)
            {
                Console.WriteLine("A variável 2: " + variavel2 + " é maior que a variável 1: " + variavel1);
            }



            Console.WriteLine("\nExercício 5:");

            double nota1 = 8;
            double nota2 = 8;

            double notaFinal = (nota1 + nota2) / 2;

            if (notaFinal >=7)
            {
                Console.WriteLine("Foi Aprovado com a nota: " + notaFinal);
            } else
            {
                Console.WriteLine("Foi Reprovado com a nota: " + notaFinal);
            }
        }
    }
}
