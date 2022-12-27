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
    [RoutePrefix("api/specialist")]
    public class SpecialistController : ApiController
    {
        // Get all courses
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllSpecialists()
        {
            try
            {
                var data = SpecialistServices.Get();
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
        public HttpResponseMessage GetASpecialist(int Id)
        {
            try
            {
                var data = SpecialistServices.Get(Id);
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
        public HttpResponseMessage AddSpecialist(SpecialistDTO dto)
        {
            try
            {
                var data = SpecialistServices.Add(dto);

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
        public HttpResponseMessage DeleteSpecialist(int Id)
        {
            try
            {
                var data = SpecialistServices.Delete(Id);

                if (data != null) return Request.CreateResponse(HttpStatusCode.NoContent);

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid Id" });

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Add a course
        [HttpPatch]
        [Route("update")]
        public HttpResponseMessage UpdateSpecialist(SpecialistDTO dto)
        {
            try
            {
                var data = SpecialistServices.Update(dto);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("specialistLogin")]
        public HttpResponseMessage GetToken()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { TokenKey = "Henlo" });
        }

    }
}
