using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Peao : Peca{
        public Peao(Tabuleiro.Tabuleiro tabuleiro, Cor cor):base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "P";
        }

        private bool podeMover(Posicao pos) {
            Peca peca = tabuleiro.peca(pos);
            return peca == null || peca.cor != cor;
        }

        private bool existeInimigo(Posicao pos) {
            Peca p = tabuleiro.peca(pos);
            return p != null && p.cor != this.cor;
        }

        private bool livre(Posicao pos) {
            return tabuleiro.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            if(cor == Cor.Branca) {
                
                pos.definirValores(posicao.Linha - 1, posicao.Coluna);
                if(tabuleiro.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(posicao.Linha - 2, posicao.Coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos) && qtdMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(posicao.Linha - 1, posicao.Coluna -1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else {

                pos.definirValores(posicao.Linha + 1, posicao.Coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(posicao.Linha + 2, posicao.Coluna);
                if (tabuleiro.posicaoValida(pos) && livre(pos) && qtdMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
                if (tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
        }
    }
}
