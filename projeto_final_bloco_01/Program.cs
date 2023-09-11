using System;

namespace projeto_final_bloco_01_
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int id, tipo, opcao;
            string nome;
            decimal preco;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("     PETSHOP ZANI - SEMPRE AO SEU LADO       ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("         1 - Criar Produto                   ");
                Console.WriteLine("         2 - Lista todas os Produtos         ");
                Console.WriteLine("         3 - Buscar Produto por Id           ");
                Console.WriteLine("         4 - Atualizar Produto               ");
                Console.WriteLine("         5 - Deletar Produto                 ");
                Console.WriteLine("         6 - Sair                            ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("Entre com a opção desejada:                  ");
                Console.WriteLine("                                             ");
                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor inteiro entre 1 e 6");
                    opcao = 0;
                    Console.ResetColor();
                }

                if (opcao == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n PetShop Zani - sempre ao seu lado!");
                    sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Criar Produto \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Nome do Produto: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                          do
                          {
                            Console.WriteLine("Digite o Tipo do Produto:");
                            tipo = Convert.ToInt32(Console.ReadLine());
                          } while (tipo != 1 && tipo != 2);

                            Console.WriteLine("Digite o Preço:");
                            preco = Convert.ToInt32(Console.ReadLine());


                        KeyPress();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todas os Produtos\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Buscar por Produtos \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar Produtos \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Produto\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        

                        KeyPress();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                }

            }

            static void sobre()
            {
                Console.WriteLine("\n*************************************************");
                Console.WriteLine("Projeto Desenvolvido por: Karina Akina ");
                Console.WriteLine("Karina Akina - Karinamzk2@gmail.com");
                Console.WriteLine("https://github.com/karinamzk");
                Console.WriteLine("***************************************************");
            }

            static void KeyPress()
            {
                do
                {
                    Console.Write("\nPress Enter to continue!");
                    consoleKeyInfo = Console.ReadKey();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
           
        }
    }
}