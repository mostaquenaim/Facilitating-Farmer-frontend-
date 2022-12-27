using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        // Get all courses
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllAdmin()
        {
            try
            {
                var data = AdminServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get a courses
        [HttpGet]
        [Route("{Id}")]
        public HttpResponseMessage GetAAdmin(int Id)
        {
            try
            {
                var data = AdminServices.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Add a course
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage AddAdmin(AdminDTO adminDTO)
        {
            try
            {
                var data = AdminServices.Add(adminDTO);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Delete a course
        [HttpDelete]
        [Route("delete/{Id}")]
        public HttpResponseMessage DeleteAdmin(int Id)
        {
            try
            {
                var data = AdminServices.Delete(Id);

                if (data != null) return Request.CreateResponse(HttpStatusCode.NoContent);

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid Id" });

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
