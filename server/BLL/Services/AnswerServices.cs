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
    public static class AnswerServices
    {
        // Get all Answers
        public static List<AnswerDTO> Get()
        {
            var difficulties = DataAccessFactory.AnswerDataAccess().Get();

            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Answer, AnswerDTO>();

            });

            var mapper = new Mapper(config);

            return mapper.Map<List<AnswerDTO>>(difficulties);

        }

        // Get Answer with id
        public static AnswerDTO Get(int Id)
        {
            var data = DataAccessFactory.AnswerDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Answer, AnswerDTO>();
                cfg.CreateMap<Course, CourseDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<AnswerDTO>(data);

        }
        // add a Answer
        public static AnswerDTO Add(AnswerDTO dto)
        {
            dto.DatePosted = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerDTO, Answer>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Answer>(dto);

            var ret = DataAccessFactory.AnswerDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        

        // Delete a Answer
        public static AnswerDTO Delete(int Id)
        {
            var data = DataAccessFactory.AnswerDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Answer, AnswerDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<AnswerDTO>(data);
        }
        //Update a Answer
        public static AnswerDTO Update(AnswerDTO dto)
        {
            dto.DatePosted = DateTime.Now;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerDTO, Answer>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Answer>(dto);

            var ret = DataAccessFactory.AnswerDataAccess().Update(dbObj);

            return Get(ret.Id);

        }
    }
}

