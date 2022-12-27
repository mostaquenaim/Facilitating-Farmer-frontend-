using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseServices
    {
        // Get all courses
        public static List<CourseSummaryDTO> Get()
        {
            var data = DataAccessFactory.CourseDataAccess().Get();

            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<Course, CourseSummaryDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CourseSummaryDTO>>(data);

        }

        // Get course by Id
        public static CourseSummaryDTO Get(int Id)
        {
            var data = DataAccessFactory.CourseDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Course, CourseSummaryDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<CourseSummaryDTO>(data);

        }

        // add a course
        public static CourseSummaryDTO Add(CourseDTO dto)
        {
            dto.LastUpdatedAt = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CourseDTO, Course>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Course>(dto);

            var ret = DataAccessFactory.CourseDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        // Delete a course
        public static CourseDTO Delete(int Id)
        {
            var data = DataAccessFactory.CourseDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<CourseDTO>(data);
        }

        public static CourseDTO Update(CourseDTO dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CourseDTO, Course>();
                cfg.CreateMap<Course, CourseDTO>();
            });

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Course>(dto);

            var ret = DataAccessFactory.CourseDataAccess().Update(dbObj);

            return mapper.Map<CourseDTO>(ret);
        }
    }
}
