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
    [RoutePrefix("v1/api/reservaciones")]
    public class ReservacionesController : ApiController
    {
        private ReservacionBLL reservacionBLL = ReservacionBLL.Instance();

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Add(Reservacion reservacion)
        {
            return Request.CreateResponse(HttpStatusCode.OK, reservacionBLL.Add(reservacion));

        }

        [HttpPost]
        [Route("changestatus")]
        public HttpResponseMessage ChangeStatus(Reservacion reservacion)
        {
            return Request.CreateResponse(HttpStatusCode.OK, reservacionBLL.ChangeStatus(reservacion));
        }

        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, reservacionBLL.GetAll());
        }

        [HttpGet]
        [Route("espera")]
        public HttpResponseMessage GetEnEspera()
        {
            return Request.CreateResponse(HttpStatusCode.OK, reservacionBLL.GetEspera());
        }

        [HttpGet]
        [Route("activas")]
        public HttpResponseMessage GetActivas()
        {
            return Request.CreateResponse(HttpStatusCode.OK, reservacionBLL.GetActivas());
        }
    }
}
