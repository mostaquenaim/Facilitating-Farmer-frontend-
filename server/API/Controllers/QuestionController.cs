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
    public class QuestionController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllQuestions()
        {
            try
            {
                var data = QuestionServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get Question by id
        [HttpGet]
        [Route("Question/{id}")]
        public HttpResponseMessage GetAnswer(int id)
        {
            try
            {
                var data = QuestionServices.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // Add a Q
        [HttpPost]
        [Route("Question/add")]
        public HttpResponseMessage AddQuestion(QuestionDTO dto)
        {
            try
            {
                var data = QuestionServices.Add(dto);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Delete a Question
        [HttpDelete]
        [Route("Question/delete/{Id}")]
        public HttpResponseMessage DeleteQuestion(int Id)
        {
            try
            {
                var data = QuestionServices.Delete(Id);

                if (data != null) return Request.CreateResponse(HttpStatusCode.NoContent);

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid Id" });

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Add a Question
        [HttpPatch]
        [Route("update")]
        public HttpResponseMessage Update(QuestionDTO dto)
        {
            try
            {
                var data = QuestionServices.Update(dto);

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
