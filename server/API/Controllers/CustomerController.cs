using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FinalProject.Authorization;

namespace server.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        [ValidCus]
        [HttpGet]
        [Route("api/customer/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CustomerServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        
        [HttpGet]
        [Route("api/customer/{ID}")]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = CustomerServices.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/customer/add")]
        public HttpResponseMessage Add(CustomerDTO dto)
        {
            try
            {
                var data = CustomerServices.Add(dto);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPatch]
        [Route("api/customer/{Id}")]
        public HttpResponseMessage Update(CustomerDTO dto)
        {
            try
            {
                var data = CustomerServices.Update(dto);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/customer/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = CustomerServices.Delete(Id);

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
