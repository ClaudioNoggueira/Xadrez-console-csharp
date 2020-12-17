namespace Xadrez_Console.Tabuleiro {
    class Tabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peace(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca peca, Posicao pos) {
            pecas[pos.Linha, pos.Coluna] = peca;
            peca.posicao = pos;
        }
    }
}
