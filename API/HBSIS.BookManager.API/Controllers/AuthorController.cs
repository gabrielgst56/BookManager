using HBSIS.BookManager.Business.Business;
using HBSIS.BookManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HBSIS.BookManager.WebAPI.Controllers
{
    [RoutePrefix("author")]
    public class AuthorController : ApiController
    {
        [HttpGet]
        [Route("list")]
        public HttpResponseMessage List()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new AuthorBusiness().List());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("getbyname/{name}")]
        public HttpResponseMessage GetByName(string name)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new AuthorBusiness().GetByName(name));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(Author author)
        {
            try
            {
                new AuthorBusiness().Add(author);

                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch (Exception ex)
                {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
