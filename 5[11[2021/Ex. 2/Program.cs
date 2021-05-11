using System;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorGas = 5.30;
            double gasDescontado = 5.088;
            double valorAlc = 4.90;
            double alcDescontado = 4.704;

            Console.WriteLine("Deseja abastecer com gasolina (g) ou álcool (a)?");
            string tipoComb = Console.ReadLine().ToLower();
            Console.WriteLine($"Quantos litros de {tipoComb} deseja colocar?");
            int litros = int.Parse(Console.ReadLine());

            switch (tipoComb)
            {
                case "g":
                if (litros <= 20){
                    Console.WriteLine("O valor é: R$" + litros * valorGas);
                } else{
                    Console.WriteLine("O valor é: R$" + litros * gasDescontado);
                }
                break;

                case "a":
                if (litros <=20){
                    Console.WriteLine("O valor é: R$" + litros * valorAlc);
                } else{
                    Console.WriteLine("O valor é: R$" + litros * alcDescontado);
                }
                break;
            }
            
        }
    }
}
