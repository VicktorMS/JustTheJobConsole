namespace JustTheJobConsole.Models
{
    public class Avaliacao: Operacao
    {
        public double Valor { get; set; }

        public Avaliacao(
           Cliente cliente,
           Imovel imovel,
           DateTime dataInicial,
           DateTime dataFinal,
           double valor
         ) : base(imovel, cliente, dataInicial, dataFinal)
        {
            Valor = valor;
        }

    }
}