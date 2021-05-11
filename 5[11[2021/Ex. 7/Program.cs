using System;

namespace Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            Console.WriteLine("Insira 15 números");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)} número:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 15 - 1; i >= 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
