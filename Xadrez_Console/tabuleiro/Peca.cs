namespace Xadrez_Console.Tabuleiro {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            this.posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            qtdMovimentos = 0;
        }

        public void incrementarQtdMovimentos() {
            qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
