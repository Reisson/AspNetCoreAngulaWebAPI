using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("Reisson"));
            jogo.IniciarJogo();
        }
    }

}