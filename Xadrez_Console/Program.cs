using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tabuleiro);
        }
    }
}
