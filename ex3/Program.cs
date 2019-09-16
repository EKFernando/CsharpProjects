using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float Anos;

            Console.WriteLine("Quantos anos você tem?");
            Anos = int.Parse(Console.ReadLine());

            float Meses = Anos *12;
 
            Console.WriteLine($"Você tem {Meses} meses de vida");

            float Dias =  Anos *365;

            Console.WriteLine($"Você tem {Dias} Dias de vida");

            float Horas = Dias * 24;

            Console.WriteLine($"Você tem {Horas} Horas de vida");

            double Minutos = Horas * 60;

            Console.WriteLine($"Você tem {Minutos} Minutos de vida");
            

        }
    }
}
