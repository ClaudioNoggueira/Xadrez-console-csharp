using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Cavalo : Peca {
        public Cavalo(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "C";
        }

        private bool podeMover(Posicao pos) {
            Peca peca = tabuleiro.peca(pos);
            return peca == null || peca.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Dois para atras, um para esquerda
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }


            pos.definirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 2);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
