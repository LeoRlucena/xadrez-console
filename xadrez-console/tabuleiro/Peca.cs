namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; } 

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            qteMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();
        

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}
