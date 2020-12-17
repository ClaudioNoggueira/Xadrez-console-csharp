using System;

namespace Xadrez_Console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro board) {
            for (int i = 0; i < board.Linhas; i++) {
                for (int j = 0; j < board.Colunas; j++) {
                    if(board.peace(i,j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(board.peace(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
