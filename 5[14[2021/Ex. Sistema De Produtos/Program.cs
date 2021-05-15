using System;

namespace Ex._Sistema_De_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"
            Você tem a            ██████╗ ███████╗███╗   ███╗    ██╗   ██╗██╗███╗   ██╗██████╗  ██████╗ ██╗
            capacidade de         ██╔══██╗██╔════╝████╗ ████║    ██║   ██║██║████╗  ██║██╔══██╗██╔═══██╗██║
            cadastrar até 10      ██████╔╝█████╗  ██╔████╔██║    ██║   ██║██║██╔██╗ ██║██║  ██║██║   ██║██║
            produtos neste        ██╔══██╗██╔══╝  ██║╚██╔╝██║    ╚██╗ ██╔╝██║██║╚██╗██║██║  ██║██║   ██║╚═╝
            sistema.              ██████╔╝███████╗██║ ╚═╝ ██║     ╚████╔╝ ██║██║ ╚████║██████╔╝╚██████╔╝██╗     
                                  ╚═════╝ ╚══════╝╚═╝     ╚═╝      ╚═══╝  ╚═╝╚═╝  ╚═══╝╚═════╝  ╚═════╝ ╚═╝     
                                
            ------------------------------------------------------------------------------------------------------------------------------------------------
            ");

            do
            {
                Console.WriteLine("1 (Cadastrar produtos) 2 (Listar os produtos) 3(Mostrar o menu)");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        {
                            CadastrarProduto();
                        }
                        break;

                    case "2":
                        ListarProdutos();
                        break;

                    case "3":
                        MostrarMenu();
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        static string[] nome = new string[10];
        static float[] preco = new float[10];
        static string escolhaPromo;
        static bool promocao = false;
        static string escolha;
        static int c = 1;
        static string maisProduto;


        static void CadastrarProduto()
        {
            do
            {
                Console.WriteLine($"Digite o nome do seu {c}º produto:");
                nome[c] = Console.ReadLine().ToLower();
                Console.WriteLine($"Digite o valor do seu {c}º produto");
                preco[c] = float.Parse(Console.ReadLine());
                Console.WriteLine("O produto estará em promoção? (S/N)");
                escolhaPromo = Console.ReadLine().ToLower();
                if (escolhaPromo == "s")
                {
                    promocao = true;
                }

                Console.WriteLine("Deseja cadastrar mais um produto? (S/N)");
                maisProduto = Console.ReadLine().ToLower();

                c++;
            } while (maisProduto == "s");
        }


        static void ListarProdutos()
        {
            Console.WriteLine($"Nome      Preço\n");
            for (var i = 1; i < c; i++)
            {
                Console.WriteLine($"{nome[i]}   R${preco[i]}");
                if (promocao == true)
                {
                    escolhaPromo = nome[c];
                    Console.WriteLine($"O produto {nome[i]} está em promoção, aproveite já!!!");
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Carregando...");
        }
    }
}

