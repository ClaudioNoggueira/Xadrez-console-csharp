using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tabuleiro);
        }
    }
}
