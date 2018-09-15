using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HBSIS.BookManager.WebAPI.Controllers
{
    [RoutePrefix("book")]
    public class BookController : ApiController
    {
        [Route("list")]
        public HttpResponseMessage ListAll()
        {
            try
            {
                var response = new
                {
                    nome = "Gabriel",
                    idade = 19
                };
                return Request.CreateResponse(HttpStatusCode.OK, response);

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
