using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {Soma(numero1,numero2)}");
            
            Console.WriteLine("Aperte Enter para finalizar");

            Console.ReadLine();


        }

        public static int Soma( int n1, int n2)
        {
            return n1 + n2;
        }
    }
}