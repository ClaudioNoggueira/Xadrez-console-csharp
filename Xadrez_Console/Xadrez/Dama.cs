using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Dama :Peca{
        public Dama(Tabuleiro.Tabuleiro tabuleiro, Cor cor):base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "D";
        }

        private bool podeMover(Posicao pos) {
            Peca peca = tabuleiro.peca(pos);
            return peca == null || peca.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                    break;
                }
                pos.Linha -= 1;
            }

            //Abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                    break;
                }
                pos.Linha += 1;
            }

            //Direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                    break;
                }
                pos.Coluna += 1;
            }

            //Esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                    break;
                }
                pos.Coluna -= 1;
            }

            //Noroeste(Diagonal superior esquerda)
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //Nordeste(Diagonal superior direita)
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //Sudeste(Diagonal inferior esquerda)
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //Sudoeste(Diagonal inferior direita)
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }
}
