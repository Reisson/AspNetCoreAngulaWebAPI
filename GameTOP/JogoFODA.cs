namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _Jogador;

        public JogoFODA(iJogador jogador)
        {
            _Jogador = jogador;
        }
        public void IniciarJogo()
        {
            _Jogador.Corre();
            _Jogador.Chuta();
            _Jogador.Passe();
        }
    }

}