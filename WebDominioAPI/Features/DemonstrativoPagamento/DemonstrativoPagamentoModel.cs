using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDominioAPI.Features.DemonstrativoPagamento
{
    public class DemonstrativoPagamentoReferenciaFilter
    {
        public long idCliente { get; set; }
        public string Chapa { get; set; }
        public bool? IsDominio { get; set; }

    }

    public class DemonstrativoPagamentoReferenciaGrid
    {
        public string Mes { get; set; }
        public string Ano { get; set; }
    }

    public class DemonstrativoPagamentoFilter
    {
        public long idCliente { get; set; }
        public string chapa { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public int numeroPeriodo { get; set; }

    }

    public class DemonstrativoPagamentoGrid
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public decimal Ref { get; set; }
        public decimal Valor { get; set; }
        public int NroPeriodo { get; set; }

        public decimal BaseFGTS { get; set; }
        public decimal BaseIRRF { get; set; }
        public decimal BaseINSS { get; set; }
        public decimal BaseSalario { get; set; }
        public decimal FgtsMes { get; set; }
        public string Referencia { get; set; }
        public decimal TotalVencimento { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalLiquido { get; set; }
        public string TipoHolerite { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Chapa { get; set; }
        public string NomeFuncionario { get; set; }
        public string Departamente { get; set; }
        public string Cargo { get; set; }
    }

}