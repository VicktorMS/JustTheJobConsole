﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JustTheJobConsole.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }

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

        public void MarcarVisitaParaCotacao(DateTime data, Imovel imovel, Funcionario gerente) 
        { 
			 throw new NotImplementedException();
		}
	}
}