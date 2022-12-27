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
    public class CategoryServices
    {
        // Get all categories
        public static List<CategoryDTO> Get()
        {
            var data = DataAccessFactory.CategoryDataAccess().Get();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>();

            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CategoryDTO>>(data);
        }

        // Get category by id
        public static CategoryCourseDTO Get(int Id)
        {
            var data = DataAccessFactory.CategoryDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryCourseDTO>();
                cfg.CreateMap<Course, CourseDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<CategoryCourseDTO>(data);
        }

        public static CategoryDTO Add(CategoryDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, Difficulty>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Category>(dto);

            var ret = DataAccessFactory.CategoryDataAccess().Add(dbObj);

            return Get(ret.Id);
        }

        public static CategoryDTO Delete(int Id)
        {
            var data = DataAccessFactory.CategoryDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Difficulty, CategoryDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<CategoryDTO>(data);
        }

        public static CategoryDTO Update(CategoryDTO dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CategoryDTO, Difficulty>();
                cfg.CreateMap<Difficulty, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Category>(dto);

            var ret = DataAccessFactory.CategoryDataAccess().Update(dbObj);

            return mapper.Map<CategoryDTO>(ret);
        }
    }
}
