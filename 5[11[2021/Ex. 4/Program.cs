using System;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 valores");

            int[] numeros = new int[10];

            for (var i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine($"Menor número: {numeros[0]}");
            Console.WriteLine($"Maior número: {numeros[(numeros.Length - 1)]}");            
        }

    }
}
