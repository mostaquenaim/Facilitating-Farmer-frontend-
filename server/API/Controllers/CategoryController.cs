using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace server.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api")]
    public class CategoryController : ApiController
    {
        // Get all Catergory
        [HttpGet]
        [Route("Catergory")]
        public HttpResponseMessage GetAllDifficulties()
        {
            try
            {
                var data = CategoryServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get difficulty by id
        [HttpGet]
        [Route("difficulty/{id}")]
        public HttpResponseMessage GetDifficulty(int id)
        {
            try
            {
                var data = CategoryServices.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // Add a course
        [HttpPost]
        [Route("difficulty/add")]
        public HttpResponseMessage AddDifficulty(CategoryDTO dto)
        {
            try
            {
                var data = CategoryServices.Add(dto);

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
        [Route("difficulty/delete/{Id}")]
        public HttpResponseMessage DeleteDifficulty(int Id)
        {
            try
            {
                var data = CategoryServices.Delete(Id);

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
        public HttpResponseMessage DifficultySpecialist(CategoryDTO dto)
        {
            try
            {
                var data = CategoryServices.Update(dto);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
