using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BOL;

namespace API.REST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("v1/api/canchas")]
    public class CanchasController : ApiController
    {

        private CanchaBLL canchaBLL = CanchaBLL.Instance();

        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetAll(Cancha cancha)
        {
            return Request.CreateResponse(HttpStatusCode.OK, canchaBLL.GetAll());
        }

    }
}
