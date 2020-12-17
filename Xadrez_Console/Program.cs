using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicaoXadrez);

            Console.WriteLine(posicaoXadrez.toPosicao());

            Console.ReadLine();
        }
    }
}
