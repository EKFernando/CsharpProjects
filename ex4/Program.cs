using System;

namespace ex4
{
    class Program
    {
        private const int V = 52;

        static void Main(string[] args)
        {
            int dataDeNascimento;
            int dataAtual;

            Console.WriteLine("Em que ano nós estamos?");
            dataAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Coloque o seu ano de nascimento?");
            dataDeNascimento = int.Parse(Console.ReadLine());

            int idade = dataAtual - dataDeNascimento;

            Console.WriteLine($"Você tem {idade} anos de idade");

            Console.WriteLine(value: $"Você tem {idade * V} semanas de idade");

        }
    }
}
