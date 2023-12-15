using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTheJobConsole.Models
{
    public class Servico
    {
		public int Id { get; set; }
        public Imovel Imovel { get; set; }
        public DateTime DataExecucao { get; set; }
        public DateTime DataTerminio { get; set; }
        public Cliente Cliente { get; set; }
        public double Valor { get; set; }
        public Funcionario Gerente { get; set; }
		private List<Funcionario> Equipe { get; set; }


		public void AdicionarMembroAEquipe(Funcionario func)
        {
            throw new NotImplementedException();
        }

        public void FinalizarServico()
        {
            throw new NotImplementedException();
        }

		public void MarcarVisitaParaCotacao(DateTime data, Imovel imovel, Funcionario gerente)
		{
			throw new NotImplementedException();
		}

	}
}
