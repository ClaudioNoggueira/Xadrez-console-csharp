using System;

namespace Xadrez_Console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro) {
            for (int i = 0; i < tabuleiro.Linhas; i++) {
                for (int j = 0; j < tabuleiro.Colunas; j++) {
                    if(tabuleiro.peca(i,j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tabuleiro.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
