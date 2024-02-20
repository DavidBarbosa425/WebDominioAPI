using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebDominioAPI.Features.ImportarClienteDominio
{
    public class ImportarClienteDominioController : ApiController
    {
        ImportarClienteDominioService service = new ImportarClienteDominioService();

        [HttpPost]
        public IHttpActionResult ImportarCliente(Cliente cliente)
        {
            try
            {
                return Ok(service.ImportarCliente(cliente));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}