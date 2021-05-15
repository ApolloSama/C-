using System;

namespace Projetos_Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaLogin;
            string senhaValida = "123456";
            bool dadosValidos = false;
            bool repeticaoCadastro = false;
            int contadorCadastro = 0;

            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.WriteLine("Seja bem vindo, digite a sua senha para validar o login:");
            do
            {
                Console.WriteLine("Digite a sua senha");
                senhaLogin = Console.ReadLine();

                if (senhaLogin == "123456")
                {
                    Console.WriteLine("Senha válida, prosseguindo...");
                }
                else
                {
                    Console.WriteLine("Senha incorreta, tente novamente");
                }

            } while (senhaLogin != senhaValida);

            do
            {
                Console.WriteLine("Digite o que deseja fazer: 1 (Cadastrar Passagem), 2 (Listar Passagens), 0 (Sair)");
                string escolha = (Console.ReadLine());

                switch (escolha)
                {
                    case "1":
                        {
                            do
                            {
                               Console.WriteLine("Digite o seu nome:");
                                nome[contadorCadastro] = (Console.ReadLine());
                                Console.WriteLine("Digite a sua origem:");
                                origem[contadorCadastro] = (Console.ReadLine());
                                Console.WriteLine("Digite o seu destino");
                                destino[contadorCadastro] = (Console.ReadLine());
                                Console.WriteLine("Digite a data do voo");
                                data[contadorCadastro] = (Console.ReadLine());
                                Console.WriteLine("Deseja criar mais um cadastro? S/N");

                                contadorCadastro++; 
                            } while (dadosValidos);
                        }
                        break;

                    case "2":

                        break;

                    case "0":
                        repeticaoCadastro = true;
                        break;

                    default:
                        break;

                } 
            }while (!repeticaoCadastro);

        }
    }
}
