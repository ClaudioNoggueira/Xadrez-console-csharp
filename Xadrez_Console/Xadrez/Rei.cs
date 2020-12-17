using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Rei : Peca {
        public Rei(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao posicao) {
            Peca peca = tabuleiro.peca(posicao);
            return peca == null || peca.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            //Acima
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Nordeste
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Direita
            posicao.definirValores(posicao.Linha, posicao.Coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Sudeste
            posicao.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Abaixo
            posicao.definirValores(posicao.Linha + 1, posicao.Coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Sudoeste
            posicao.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Esquerda
            posicao.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Noroeste
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            return mat;
        }
    }
}
