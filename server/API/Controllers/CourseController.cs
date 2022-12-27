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
    [RoutePrefix("api/course")]
    public class CourseController : ApiController
    {
        // Get all courses
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllCourses()
        {
            try
            {
                var data = CourseServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            } catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get a courses
        [HttpGet]
        [Route("{Id}")]
        public HttpResponseMessage GetACourse(int Id)
        {
            try
            {
                var data = CourseServices.Get(Id);
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
        public HttpResponseMessage AddCourse(CourseDTO courseDTO)
        {
            try
            {
                var data = CourseServices.Add(courseDTO);

                if (data != null) return Request.CreateResponse(HttpStatusCode.Created, data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, data);

            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Delete a course
        [HttpDelete]
        [Route("delete/{Id}")]
        public HttpResponseMessage DeleteCourse(int Id)
        {
            try
            {
                var data = CourseServices.Delete(Id); 

                if (data != null) return Request.CreateResponse(HttpStatusCode.NoContent);
                    
                return Request.CreateResponse(HttpStatusCode.BadRequest, new {Message="Invalid Id"});

            }catch (Exception ex)
            {
               return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // Get all difficulties
        [HttpGet]
        [Route("difficulties")]
        public HttpResponseMessage GetAllDifficulties()
        {
            try
            {
                var data = DifficultyServices.Get();
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
                var data = DifficultyServices.GetWithCourses(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        
        }

        // Get all categories
        [HttpGet]
        [Route("categories")]
        public HttpResponseMessage GetAllCategories()
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

        // Get category by id
        [HttpGet]
        [Route("categories/{id}")]
        public HttpResponseMessage GetCategory(int id)
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

        [HttpPatch]
        [Route("update")]
        public HttpResponseMessage Update(CourseDTO dto)
        {
            try
            {
                var data = CourseServices.Update(dto);

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
