using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Torre : Peca {
        public Torre(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "T";
        }
    }
}
