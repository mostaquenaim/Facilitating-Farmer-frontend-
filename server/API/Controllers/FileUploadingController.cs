using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace server.Controllers
{
    public class FileUploadingController : ApiController
    {
        [HttpPost]
        [Route("api/FileUploading/UploadFile")]
        public async Task<string> UploadFile()
        {
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/App_Data");
            var provider =
                new MultipartFormDataStreamProvider(root);

            try
            {
                await Request.Content
                    .ReadAsMultipartAsync(provider);


            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }

            return "File uploaded!";
        }
    }
}