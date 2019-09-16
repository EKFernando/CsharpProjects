using System;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe sua Idade");
            idade = int.Parse(Console.ReadLine());


            if (idade <= 7){
                Console.WriteLine("Você está classificado como Infantil A");
            }
            else if (idade <= 10){
                Console.WriteLine("Você está classificado como Infantil B");
            }
            else if (idade <= 13){
                Console.WriteLine("Você está classificado como Juvenil A");
            }
            else if (idade <= 17){
                Console.WriteLine("Você está classificado como Juvenil B");
            }
            else{
                Console.WriteLine("Você está classificado como Adulto");
            }



        }
    }
}
