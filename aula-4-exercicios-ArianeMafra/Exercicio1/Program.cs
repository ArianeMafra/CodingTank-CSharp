using System;
using System.Numerics;

namespace Exercicio1
{
    class Program
    {
        static char[,] tabuleiro = new char[3, 3];
        static void Main(string[] args)
        {
            PreencherTabuleiroVazio();
            int jogadas = 0;
            bool partidaTerminou = false;
            char jogador = 'X';

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Bem-vindo ao Jogo da Velha!");
            Console.WriteLine();
            Console.WriteLine("Regras:");
            Console.WriteLine("* O Jogador 1 é representado pelo X e o Jogador 2 é representado pelo O. ");
            Console.WriteLine("* O jogador com o X, sempre começa jogando.");
            Console.WriteLine("* Digite a linha (1 a 3) e a coluna (1 a 3) para fazer a jogada.");
            Console.WriteLine("* Campos que já estão ocupados não podem ser escolhidos novamente.");
            Console.WriteLine();
            Console.WriteLine("Pressione Enter para começar ...");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ReadLine();


            while (jogadas < 9 && !partidaTerminou)
            {
                Console.Clear();
                MostrarTabuleiro();
                Console.WriteLine($"Jogador {jogador} digite sua jogada.");
                Console.Write("Linha: ");
                bool entrada1 = int.TryParse(Console.ReadLine(), out int linha);
                Console.Write("Coluna: ");
                bool entrada2 = int.TryParse(Console.ReadLine(), out int coluna);

                if (entrada1 && entrada2)
                {
                    if (VerificarJogada(linha, coluna))
                    {
                        tabuleiro[linha - 1, coluna - 1] = jogador;
                        jogadas++;

                        if (VerificarVencedor(linha, coluna))
                        {
                            MostrarTabuleiro();
                            if (jogador == 'X')
                            {
                                Console.WriteLine("O jogador 1 venceu!");
                            } else
                            {
                                Console.WriteLine("O jogador 2 venceu!");
                            }                           
                            partidaTerminou = true;
                        }
                        else
                        {
                            MostrarTabuleiro();
                            jogador = (jogador == 'X') ? 'O' : 'X';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Jogada inválida! Tente novamente.");
                    }
                }
            }
            if (!partidaTerminou && jogadas >= 9)
            {
                Console.WriteLine("Partida sem vencedor!");
            }

        }

        static bool VerificarJogada(int linha, int coluna)
        {
            if ((linha <= 3) && (coluna <= 3) && (tabuleiro[linha - 1, coluna - 1] == '-'))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void MostrarTabuleiro()
        {
            Console.WriteLine("Tabuleiro:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PreencherTabuleiroVazio()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = '-';
                }
            }
        }

        static bool VerificarVencedor(int linha, int coluna)
        {
            if ((tabuleiro[linha - 1, 0] == tabuleiro[linha - 1, 1]) && (tabuleiro[linha - 1, 0] == tabuleiro[linha - 1, 2]) && (tabuleiro[linha - 1, 1] == tabuleiro[linha - 1, 2]))
            {
                return true;
            }
            else if ((tabuleiro[0, coluna - 1] == tabuleiro[1, coluna - 1]) && (tabuleiro[0, coluna - 1] == tabuleiro[2, coluna - 1]) && (tabuleiro[1, coluna - 1] == tabuleiro[2, coluna - 1]))
            {
                return true;
            }
            else if ((tabuleiro[0, 0] == tabuleiro[1, 1]) && (tabuleiro[0, 0] == tabuleiro[2, 2]) && (tabuleiro[1, 1] == tabuleiro[2, 2] && tabuleiro[2,2] != '-')
                || (tabuleiro[0, 2] == tabuleiro[1, 1]) && (tabuleiro[0, 0] == tabuleiro[2, 2]) && (tabuleiro[1, 1] == tabuleiro[2, 0]) && tabuleiro[2, 2] != '-')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
