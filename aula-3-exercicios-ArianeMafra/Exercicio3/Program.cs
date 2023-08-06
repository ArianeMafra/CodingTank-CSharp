using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroComum = 0;
            int numeroPreferencial = 0;
            List<string> filaComum = new List<string> ();
            List<string> filaPreferencial = new List<string>();

            bool encerrar = false;

            while (!encerrar)
            {
                Menu();
                bool entrada = int.TryParse(Console.ReadLine(), out int opcao);

                if (entrada)
                {
                    switch (opcao)
                    {
                        case 1:
                            numeroPreferencial++;
                            string senhaPreferencial = "P" + numeroPreferencial.ToString("D3");
                            filaPreferencial.Add(senhaPreferencial);
                            Console.WriteLine("Senha gerada: " + senhaPreferencial);
                            break;
                        case 2:
                            numeroComum++;
                            string senhaComum = "C" + numeroComum.ToString("D3");
                            filaComum.Add(senhaComum);
                            Console.WriteLine("Senha: " + senhaComum);
                            break;
                        case 3:
                            if (filaPreferencial.Count() > 0)
                            {
                                Console.WriteLine("Proxima senha: " + filaPreferencial[0]);
                                filaPreferencial.RemoveAt(0);
                            }
                            else if (filaComum.Count() > 0)
                            {                                                     
                                Console.WriteLine("Proxima senha: " + filaComum[0]);
                                filaComum.RemoveAt(0);
                            } else
                            {
                                Console.WriteLine("Fila vazia!");
                            }
                            break;
                        case 4:
                            entrada = true;
                            Console.WriteLine("Você saiu do sistema!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                }
            }
        }

        private static void Menu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Sistema de Distribuição de Senhas!");
            Console.WriteLine("Entre com o número da opção desejada");
            Console.WriteLine("1 - Emitir Senha Preferencial");
            Console.WriteLine("2 - Emitir Senha Comum");
            Console.WriteLine("3 - Chamar Próxima Senha");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("---------------------------------------");
        }
    }
}
