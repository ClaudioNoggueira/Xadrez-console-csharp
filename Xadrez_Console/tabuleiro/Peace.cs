using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Tabuleiro {
    class Peace {
        public Position posicao { get; set; }
        public Color cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Board tabuleiro { get; protected set; }

        public Peace(Position posicao, Board tabuleiro, Color cor) {
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            qtdMovimentos = 0;
        }
    }
}
