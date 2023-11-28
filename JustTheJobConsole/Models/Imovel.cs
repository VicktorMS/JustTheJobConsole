namespace JustTheJobConsole.Models
{
    public class Imovel
    {
        public Cliente Cliente { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }

        public Imovel(Cliente cliente, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, int cep)
        {
            Cliente = cliente;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public void VisualizarDadosDoProprietario()
        {
            throw new NotImplementedException();
        }

        public void VisualizarDadosDoImovel()
        {
            throw new NotImplementedException();
        }

        public void VisualizarHistoricoServico()
        {
            throw new NotImplementedException();
        }
    }
}