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
    public class QuestionServices
    {
        // Get all Questions
        public static List<QuestionDTO> Get()
        {
            var data = DataAccessFactory.QuestionDataAccess().Get();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Question, QuestionDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<QuestionDTO>>(data);

        }

        // Get Question by Id
        public static QuestionDTO Get(int Id)
        {
            var data = DataAccessFactory.QuestionDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Question, QuestionDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<QuestionDTO>(data);

        }

        // add a Question
        public static QuestionDTO Add(QuestionDTO dto)
        {
            dto.DatePosted = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionDTO, Question>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Question>(dto);

            var ret = DataAccessFactory.QuestionDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        // Delete a Question
        public static QuestionDTO Delete(int Id)
        {
            var data = DataAccessFactory.QuestionDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Question, QuestionDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<QuestionDTO>(data);
        }
        //update a question
        public static QuestionDTO Update(QuestionDTO dto)
        {
            dto.DatePosted = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionDTO, Question>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Question>(dto);

            var ret = DataAccessFactory.QuestionDataAccess().Update(dbObj);

            return Get(ret.Id);

        }
    }
}
