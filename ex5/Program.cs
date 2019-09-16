using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um Numero: ");
            numero = int.Parse(Console.ReadLine());

            int resultado = numero * 3;

            Console.WriteLine($"O Resultado é: {resultado}");


        }
    }
}
    