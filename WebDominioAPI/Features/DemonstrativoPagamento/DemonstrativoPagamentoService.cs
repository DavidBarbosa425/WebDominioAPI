using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDominioAPI.Features.DemonstrativoPagamento
{
    public class DemonstrativoPagamentoService
    {
        DemonstrativoPagamentoDAO demonstrativoPagamentoDAO = new DemonstrativoPagamentoDAO();
        public List<DemonstrativoPagamentoGrid> GetDemonstrativoPagamento(DemonstrativoPagamentoFilter pFilter)
        {

            return demonstrativoPagamentoDAO.GetDemonstrativoPagamento(pFilter);

        }
    }
}