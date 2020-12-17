using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Torre : Peca {
        public Torre(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {

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
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
                if(tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != this.cor) {
                    break;
                }
                posicao.Linha = posicao.Linha - 1;
            }

            //Abaixo
            posicao.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != this.cor) {
                    break;
                }
                posicao.Linha = posicao.Linha + 1;
            }

            //Direita
            posicao.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != this.cor) {
                    break;
                }
                posicao.Coluna = posicao.Coluna + 1;
            }

            //Esquerda
            posicao.definirValores(posicao.Linha, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != this.cor) {
                    break;
                }
                posicao.Coluna = posicao.Coluna - 1;
            }

            return mat;
        }

        public override string ToString() {
            return "T";
        }
    }
}
