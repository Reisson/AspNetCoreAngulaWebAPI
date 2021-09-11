namespace GameTOP
{
    public class JogoFODA
    {
        private readonly Jogador _Jogador;

        public JogoFODA(Jogador jogador)
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