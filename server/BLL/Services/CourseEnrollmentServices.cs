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
    public class CourseEnrollmentServices
    {
        // Get all CourseEnrollments
        public static List<CourseEnrollmentDTO> Get()
        {
            var data = DataAccessFactory.CourseEnrollmentDataAccess().Get();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CourseEnrollment, CourseEnrollmentDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CourseEnrollmentDTO>>(data);

        }

        // Get CourseEnrollment by Id
        public static CourseEnrollmentDTO Get(int Id)
        {
            var data = DataAccessFactory.CourseEnrollmentDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CourseEnrollment, CourseEnrollmentDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<CourseEnrollmentDTO>(data);

        }

        // add a CourseEnrollment
        public static CourseEnrollmentDTO Add(CourseEnrollmentDTO dto)
        {
            dto.LastUpdatedAt = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CourseEnrollmentDTO, CourseEnrollment>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<CourseEnrollment>(dto);

            var ret = DataAccessFactory.CourseEnrollmentDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        // Delete a CourseEnrollment
        public static CourseEnrollmentDTO Delete(int Id)
        {
            var data = DataAccessFactory.CourseEnrollmentDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CourseEnrollment, CourseEnrollmentDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<CourseEnrollmentDTO>(data);
        }
        // Update CourseEnrollment
        public static CourseEnrollmentDTO Update(CourseEnrollmentDTO dto)
        {
            dto.LastUpdatedAt = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CourseEnrollmentDTO, CourseEnrollment>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<CourseEnrollment>(dto);

            var ret = DataAccessFactory.CourseEnrollmentDataAccess().Update(dbObj);

            return Get(ret.Id);

        }
    }
}
