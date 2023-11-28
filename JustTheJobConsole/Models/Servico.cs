using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTheJobConsole.Models
{
    public class Servico: Operacao
    {
        private List<Funcionario> equipe;
        private Avaliacao avaliacao;

        public Servico(
            Cliente cliente, 
            Imovel imovel, 
            DateTime dataInicial, 
            DateTime dataFinal,
            List<Funcionario> equipe, 
            Avaliacao avaliacao) : base(imovel, cliente, dataInicial, dataFinal)
        {
            this.equipe = equipe;
            this.avaliacao = avaliacao;
        }

        public void AdicionarMembroAEquipe(Funcionario func)
        {
            throw new NotImplementedException();
        }

        public void FinalizarServico()
        {
            throw new NotImplementedException();
        }

    }
}
