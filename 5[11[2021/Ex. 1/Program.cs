using System;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Digite seu ano de nascimento:");
            int anoNasc = int.Parse(Console.ReadLine());
            
            if (anoNasc >= 2005)
            {
                Console.WriteLine("Você pode votar este ano.");
            } else {
                Console.WriteLine("Você não pode votar este ano.");
            }
        }
    }
}
