using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.Tabuleiro {
    class Board {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peace[,] pecas;

        public Board(int linhas, int colunas) {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peace[linhas, colunas];
        }
    }
}
