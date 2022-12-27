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
    public class AnswerController : ApiController
    {
        
            
            [HttpGet]
            [Route("all")]
            public HttpResponseMessage GetAllAnswers()
            {
                try
                {
                    var data = AnswerServices.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

            // Get Answer by id
            [HttpGet]
            [Route("Answer/{id}")]
            public HttpResponseMessage GetAnswer(int id)
            {
                try
                {
                    var data = AnswerServices.Get(id);

                    return Request.CreateResponse(HttpStatusCode.OK, data);

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }

            }

            
            [HttpPost]
            [Route("Answer/add")]
            public HttpResponseMessage AddAnswer(AnswerDTO dto)
            {
                try
                {
                    var data = AnswerServices.Add(dto);

                    if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                    return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

            [HttpDelete]
            [Route("Answer/delete/{Id}")]
            public HttpResponseMessage DeleteAnswer(int Id)
            {
                try
                {
                    var data = AnswerServices.Delete(Id);

                    if (data != null) return Request.CreateResponse(HttpStatusCode.NoContent);

                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid Id" });

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

            // Add a answer
            [HttpPatch]
            [Route("Answer/update")]
            public HttpResponseMessage Update(AnswerDTO dto)
            {
                try
                {
                    var data = AnswerServices.Update(dto);

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
