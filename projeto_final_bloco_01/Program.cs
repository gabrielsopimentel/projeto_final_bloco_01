namespace projeto_final_bloco_01
{
    internal class Program
    {
        private static ConsoleKeyInfo cki;
        static void Main(string[] args)
        {
            int opcao;

            while (true)
            {
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("                REVENDA AUTORIZADA DE CAPIVARAS - KAPI                ");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("            1 - Inserir capivara                                      ");
                Console.WriteLine("            2 - Listar todas as capivaras                             ");
                Console.WriteLine("            3 - Buscar capivara por Numero                            ");
                Console.WriteLine("            4 - Atualizar Dados da capivara                           ");
                Console.WriteLine("            5 - Apagar capivara                                       ");
                Console.WriteLine("            6 - Sair                                                  ");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("Entre com a opção desejada:                                           ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Inserir capivara: ");


                        KeyPress();
                        break;
                    case 2:
                        Console.WriteLine("Listar todas as capivaras: ");


                        KeyPress();
                        break;
                    case 3:
                        Console.WriteLine("Buscar capivara por Numero: ");


                        KeyPress();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar Dados da capivara: ");



                        KeyPress();
                        break;
                    case 5:
                        Console.WriteLine("Apagar capivara: ");

                        KeyPress();
                        break;
                    case 6:
                        Console.WriteLine("Saindo... ");
                        System.Environment.Exit(0);

                        KeyPress();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");

                        KeyPress();
                        break;
                }

                static void KeyPress()
                {
                    do
                    {
                        Console.WriteLine("Pressione enter para continuar...");
                        cki = Console.ReadKey();
                    } while (cki.Key != ConsoleKey.Enter);
                }
            }
        }
    }
}