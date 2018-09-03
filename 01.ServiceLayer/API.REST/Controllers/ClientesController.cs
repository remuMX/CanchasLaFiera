using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.REST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("v1/api/clientes")]
    public class ClientesController : ApiController
    {
        private ClienteBLL clienteBLL = ClienteBLL.Instance();

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Add(Cliente cliente)
        {
            return Request.CreateResponse(HttpStatusCode.OK, clienteBLL.Add(cliente));
        }
        
        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, clienteBLL.GetAll());
        }


    }
}
