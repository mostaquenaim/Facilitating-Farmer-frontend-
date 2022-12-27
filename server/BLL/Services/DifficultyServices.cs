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
    public static class DifficultyServices
    {
        // Get all difficulties
        public static List<DifficultyDTO> Get()
        {
            var difficulties = DataAccessFactory.DifficultyDataAccess().Get();

            var config = new MapperConfiguration(cfg => { 

                cfg.CreateMap<Difficulty, DifficultyDTO>();

            });

            var mapper = new Mapper(config);

            return mapper.Map<List<DifficultyDTO>>(difficulties);

        }

        // Get difficulty with id
        public static DifficultyCourseDTO GetWithCourses(int Id)
        {
            var data = DataAccessFactory.DifficultyDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Difficulty, DifficultyCourseDTO>();
                cfg.CreateMap<Course, CourseDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<DifficultyCourseDTO>(data);

        }

        public static DifficultyDTO Add(DifficultyDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DifficultyDTO, Difficulty>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Difficulty>(dto);

            var ret = DataAccessFactory.DifficultyDataAccess().Add(dbObj);

            return GetWithCourses(ret.Id);
        }

        public static DifficultyDTO Delete(int Id)
        {
            var data = DataAccessFactory.DifficultyDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Difficulty, DifficultyDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<DifficultyDTO>(data);
        }

        public static DifficultyDTO Update(DifficultyDTO dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DifficultyDTO, Difficulty>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
            });

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Difficulty>(dto);

            var ret = DataAccessFactory.DifficultyDataAccess().Update(dbObj);

            return mapper.Map<DifficultyDTO>(ret);
        }
    }
}
