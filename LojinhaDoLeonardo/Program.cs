

namespace LojinhaDoLeonardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirTitulo();
            ExibirMenu();
        }

        // Mostra a moldura com o nome da loja
        static void ExibirTitulo()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                ║");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"║  █░░ █▀█ ░░█ █ █▄░█ █░█ ▄▀█   █▀▄ █▀█   █░░ █▀▀ █▀█            ║");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"║  █▄▄ █▄█ █▄█ █ █░▀█ █▀█ █▀█   █▄▀ █▄█   █▄▄ ██▄ █▄█            ║");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║                                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");

            Console.ResetColor();
        }
        static void ExibirMenu()
        {

            Console.WriteLine("\nEscolha uma opção abaixo:\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [1] Cadastrar cliente");
            Console.WriteLine(" [2] Listar os clientes");
            Console.WriteLine(" [3] Cadastrar produtos");
            Console.WriteLine(" [4] Listar os produtos");
            Console.WriteLine(" [5] Registrar venda");
            Console.WriteLine(" [-1] Sair");
            Console.ResetColor();

            Console.WriteLine("\nDigite o número da opção desejada:");
            Console.Write(">>> ");

            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    CadastrarClientes();
                    break;
                case "2":
                    ListarClientes();
                    break;
                case "3":
                    CadastrarProdutos();
                    break;
                case "4":
                    ListarProdutos();
                    break;
                case "5":
                    RegistrarVenda();
                    break;
                case "-1":
                    Console.WriteLine("\nSaindo da Lojinha do Léo... Até logo!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();

                    ExibirTitulo();
                    ExibirMenu(); // retorna ao menu
                    break;
            }

        }

        private static void RegistrarVenda()
        {
            throw new NotImplementedException();
        }

        private static void ListarProdutos()
        {
            throw new NotImplementedException();
        }

        private static void CadastrarProdutos()
        {
            throw new NotImplementedException();
        }

        private static void ListarClientes()
        {
            throw new NotImplementedException();
        }

        private static void CadastrarClientes()
        {
            throw new NotImplementedException();
        }
    }
}
