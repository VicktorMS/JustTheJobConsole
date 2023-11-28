namespace JustTheJobConsole.Models
{
    public abstract class Operacao
    {
        public Imovel Imovel { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public Operacao(Imovel imovel, Cliente cliente, DateTime dataInicial, DateTime dataFinal)
        {
            Imovel = imovel;
            Cliente = cliente;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }
    }
}