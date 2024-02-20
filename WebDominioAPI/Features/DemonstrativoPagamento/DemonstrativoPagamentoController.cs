using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebDominioAPI.Features.DemonstrativoPagamento
{
    public class DemonstrativoPagamentoController : ApiController
    {
        DemonstrativoPagamentoService demonstrativoPagamentoService = new DemonstrativoPagamentoService();
        [HttpPost]
        public List<DemonstrativoPagamentoGrid> GetDemonstrativoPagamento(DemonstrativoPagamentoFilter pFilter)
        {
            try
            {
                return demonstrativoPagamentoService.GetDemonstrativoPagamento(pFilter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
