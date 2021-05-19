using System;

namespace Criacao_de_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem();
            p1.nome = "";
            p1.armadura = "";


            Personagem p2 = new Personagem();
            p2.nome = "Bandido";
            p2.armadura = "Armadura de Couro";
            p2.hp = 15;



            Console.WriteLine("Qual será o nome do seu personagem?");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Qual é idade de seu personagem?");
            p1.idade = int.Parse(Console.ReadLine());

            
        }
    }
}
