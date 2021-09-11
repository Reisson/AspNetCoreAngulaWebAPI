using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("Reisson"));
            jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public void Chuta()
        {
            Console.Write($"{_Nome} está Chutando ");
        }
        //Corre
        public void Corre()
        {
            Console.Write($"{_Nome} está Correndo ");
        }
        //Passe
        public void Passe()
        {
            Console.Write($"{_Nome} está Passando ");
        }
    }
}