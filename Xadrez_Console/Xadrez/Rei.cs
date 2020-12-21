using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Rei : Peca {

        private PartidaDeXadrez partida;

        public Rei(Tabuleiro.Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor) {
            this.partida = partida;
        }

        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca peca = tabuleiro.peca(pos);
            return peca == null || peca.cor != this.cor;
        }

        private bool testeTorreParaRoque(Posicao pos) {
            Peca peca = tabuleiro.peca(pos);
            return peca != null && peca is Torre && peca.cor == this.cor && peca.qtdMovimentos == 0;
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

            //Jogada especial roque
            if (qtdMovimentos == 0 && !partida.xeque) {

                //#Jogada especial roque pequeno
                Posicao posT1 = new Posicao(posicao.Linha, posicao.Coluna + 3);
                if (testeTorreParaRoque(posT1)) {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna + 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna + 2);
                    if (tabuleiro.peca(p1) == null && tabuleiro.peca(p2) == null) {
                        mat[posicao.Linha, posicao.Coluna + 2] = true;
                    }
                }
                //#Jogada especial roque grande
                Posicao posT2 = new Posicao(posicao.Linha, posicao.Coluna - 4);
                if (testeTorreParaRoque(posT2)) {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna - 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna - 2);
                    Posicao p3 = new Posicao(posicao.Linha, posicao.Coluna - 3);
                    if (tabuleiro.peca(p1) == null && tabuleiro.peca(p2) == null && tabuleiro.peca(p3) == null  ) {
                        mat[posicao.Linha, posicao.Coluna - 2] = true;
                    }
                }
            }


            return mat;
        }
    }
}
