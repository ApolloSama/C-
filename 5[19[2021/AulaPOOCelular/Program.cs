using System;

namespace Exercício_celular
{
    class Program
    {
        static string ligar;
        static int escolha;
        static string escolhatel;

        static void Main(string[] args)
        {
            Celular c1 = new Celular();
            c1.cor = "Cinza";
            c1.modelo = "Telefonão";
            c1.dimensoes = "213mm×68mm×52mm";


            do
            {
                Console.WriteLine("Deseja ligar o aparelho? (S/N)");
                ligar = Console.ReadLine().ToLower();
                if (ligar == "s")
                {
                    c1.Ligar();
                }
                else if (ligar == "n")
                {
                    c1.Desligar();
                }
                else
                {
                    Console.WriteLine("???");
                }
            } while (ligar == "n");

            do
            {
                Console.WriteLine(@"
Seja bem vindo ao sistema Nokia Tijolão, o que deseja fazer?
  _________________
 /            __   \
 |           (__)  |
 |                 |
 | .-----.   .--.  |
 | |     |  /    \ |                           (\        
 | '-----'  \    / |                           \'\ 
 |           |  |  |                            \'\     ______________            
 | 01 02 03  |  |  |                            / '|   ()_____________)        Hmm, será que consigo achar   
 | 04 05 06  |  |  |Oo                          \ '/    \ 1- Telefonar \        as informações deste telefone em algum lugar?
 | 07 08 09  |  |  |`Oo                           \       \ 2- Mensagem  \                    (3- Inspecionar)
 | LI LI LI  |  |  |  Oo                          ==).      \______________\
 |           |  |  |   Oo                        (__)       ()______________)
 | .------. /    \ |   oO
 | |      | \    / |   Oo
 | '------'  '-oO  |   oO
 |          .---Oo |   Oo
 |          ||  ||`Oo  oO
 |          |'--'| | OoO
 |          '----' |
 \_________________/
");

                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        fazerLigação();
                        break;

                    case 2:
                        enviarMensagem();
                        break;

                    case 3:
                        inspecionar();
                        break;

                    default:
                        break;
                }

            } while (true);

        }
        static void fazerLigação()
        {
            Console.WriteLine(@"

            Você inspeciona a sua lista...
             _______________
            ()              \
              \(11)99005-6399 \   <- Thiago
               \ (11)98989-2984 \   <- Odirlei
                 \ (11)97783-9852 \   <- Paulo
                 ()________________)
            ");
            Console.WriteLine("Hmm, quem devo chamar?");
            escolhatel = Console.ReadLine().ToLower();
            Console.WriteLine("Chamando...");

            if (escolhatel == "thiago")
            {
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("Opa, acho que ele atendeu");
                Console.ReadLine();
                Console.WriteLine("-É que a vaca não da leite meu");
                Console.WriteLine("Celebridade é foda");
            }
            else if (escolhatel == "odirlei")
            {
                Console.WriteLine("Beleza, vamos ver se ele atende");
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine("-Laptop Gamer");
                Console.WriteLine("Laptop gamer é foda");
            }
            else if (escolhatel == "paulo")
            {
                Console.WriteLine("Será que a celebridade atende?");
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine("-Eita!");
                Console.WriteLine("É eita atrás de vixe!");
            }

        }

        static void enviarMensagem()
        {
            Console.WriteLine("Este aparelho não envia mensagens ._.");
        }

        static void inspecionar()
        {
            Console.WriteLine(@"
         _________________
        /                 \
        |(X)           (X)|
        |                 |
        |                 |
        |                 |
        |                 |
        |  _____________  |
        |  |           |  |                    Você encontra informações atrás do telemóvel
      oO|  |           |  |
     oO´|  |   Cinza   |  |
    oO  |  | Telefonão |  |  
   oO   |  | 213 × 68  |  |   
   Oo   |  |           |  |   
   oO   |  |___________|  |   
   Oo   |                 |   
   oO   |                 |   
   Oo  o|                 |
   OoO  |                 | 
        | (X)        (X)  | 
        \_________________/

            ");
        }
    }
}
