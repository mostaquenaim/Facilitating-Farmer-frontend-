using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace FinalProject.Authorization
{
    public class ValidCus : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authheader = actionContext.Request.Headers.Authorization;

            if (authheader == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "No authheader Supplied");
            }

            else
            {
                var rs = CustomerAuthServices.IsAuthenticated(authheader.ToString());

                if (rs == false)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Supplied authheader is invalid or Restricted");
                }

            }
            base.OnAuthorization(actionContext);
        }
    }
}