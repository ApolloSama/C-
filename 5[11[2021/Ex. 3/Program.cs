using System;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeProduto;
            decimal precoUnitario;

            Console.WriteLine("Qual é o produto que deseja registrar?");
            string nomeProduto = Console.ReadLine().ToLower();

            Console.WriteLine("Quantos você deseja?");
            quantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o preço de cada produto?");
            precoUnitario = decimal.Parse(Console.ReadLine());

            if (quantidadeProduto <= 5)
            {
                decimal total = quantidadeProduto * precoUnitario;
                decimal desconto = total * 2 / 100;
                decimal precoTotal = total - desconto;
                Console.WriteLine($"Preço: R${total} \n Desconto: {desconto}% \n Preço total: R${precoTotal}");
            }

            else if (quantidadeProduto > 5 && quantidadeProduto <= 10)
            {
                decimal total = quantidadeProduto * precoUnitario;
                decimal desconto = total * 3 / 100;
                decimal precoTotal = total - desconto;
                Console.WriteLine($"Preço: R${total} \n Desconto: {desconto}% \n Preço total: R${precoTotal}");
            }

            else if (quantidadeProduto > 10)
            {
                decimal total = quantidadeProduto * precoUnitario;
                decimal desconto = total * 5 / 100;
                decimal precoTotal = total - desconto;
                Console.WriteLine($"Preço: R${total} \n Desconto: {desconto}% \n Preço total: R${precoTotal}");
            }

        }
    }
}
