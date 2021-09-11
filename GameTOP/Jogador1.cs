namespace GameTOP
{
    public class Jogador1
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public void Chuta()
        {
            .Write($"{_Nome} está Chutando \n");
        }
        //Corre
        public void Corre()
        {
            .Write($"{_Nome} está Correndo \n");
        }
        //Passe
        public void Passe()
        {
            .Write($"{_Nome} está Passando \n");
        }
    }
}