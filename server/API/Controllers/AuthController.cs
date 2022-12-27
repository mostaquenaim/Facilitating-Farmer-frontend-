using BLL.DTOs;
using BLL.Services;
using DAL.EF.Models;
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
    public class AuthController : ApiController
    {
        [Route("customerLogin")]
        [HttpPost]

        public HttpResponseMessage CustomerLogin(CustomerDTO user)
        {
            var token = CustomerAuthServices.Authenticate(user);
            
            if (token != null )
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }

        [Route("adminLogin")]
        [HttpPost]

        public HttpResponseMessage AdminLogin(AdminDTO admin)
        {
            var token = AdminAuthServices.Authenticate(admin);

            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }

        [Route("specialistLogin")]
        [HttpPost]

        public HttpResponseMessage SpecialistLogin(SpecialistDTO user)
        {
            var token = SpecialistAuthServices.Authenticate(user);
            var verified = SpecialistAuthServices.Verified(user);

           

            if (token != null && verified)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            else if(token == null)     
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");

            return Request.CreateResponse(HttpStatusCode.NotFound, "Not verified"); 
        }

        [HttpGet]
        [Route("allCustomer")]
        public HttpResponseMessage GetAllTokens()
        {
            try
            {
                var data = CustomerAuthServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


    }
}
