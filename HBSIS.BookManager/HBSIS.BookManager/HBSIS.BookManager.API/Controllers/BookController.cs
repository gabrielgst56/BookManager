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
    [RoutePrefix("book")]
    public class BookController : ApiController
    {
        [HttpGet]
        [Route("list")]
        public HttpResponseMessage List()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new BookBusiness().List());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(Book book)
        {
            try
            {
                new BookBusiness().Add(book);

                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("edit")]
        public HttpResponseMessage Edit(Book book)
        {
            try
            {
                new BookBusiness().Edit(book);


                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("remove")]
        public HttpResponseMessage Remove(Book book)
        {
            try
            {
                new BookBusiness().Remove(book.BookId);


                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
