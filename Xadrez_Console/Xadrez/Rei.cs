using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Rei : Peca {
        public Rei(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca peca = tabuleiro.peca(pos);
            return peca == null || peca.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Nordeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudoeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Noroeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
