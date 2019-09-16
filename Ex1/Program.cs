using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n4;
            int n5;
            int n6;

            Console.WriteLine("Informe a primeira nota");
            n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            n5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota");
            n6 = int.Parse(Console.ReadLine());

            float notafinal = (n4 + n5 + n6);

            float media = notafinal /3;

            Console.WriteLine($"Sua nota media é {media}");



        }
    }
}
