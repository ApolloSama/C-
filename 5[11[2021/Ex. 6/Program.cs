using System;

namespace Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];

            Console.WriteLine($"Digite o nome de {nome.Length} pessoas");

            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Digite o nome da {(i + 1)} pessoa");
                nome[i] = Console.ReadLine();   
            }

            Console.WriteLine("Que nome deseja encontrar?");
            string buscaNome = Console.ReadLine();

            bool encontrado = false;

            foreach (var umNome in nome)
            {
                if (buscaNome == umNome){
                    encontrado = true;
                }
            }

            if (encontrado){
                Console.WriteLine("Achei! :P");
            } else {
                Console.WriteLine("Achei não D:");
            }

        
        }
    }
}
        
    

