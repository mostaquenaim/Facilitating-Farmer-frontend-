using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminSendMessageServices
    {
        public static List<AdminSendMessageSummaryDTO> Get()
        {
            var data = DataAccessFactory.AdminSendMessageDataAccess().Get();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminSendMessage, AdminSendMessageSummaryDTO>();
                cfg.CreateMap<Difficulty, DifficultyDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<AdminSendMessageSummaryDTO>>(data);

        }

        // Get course by Id
        public static AdminSendMessageSummaryDTO Get(int Id)
        {
            var data = DataAccessFactory.AdminSendMessageDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminSendMessage, AdminSendMessageSummaryDTO>();
                
            });

            var mapper = new Mapper(config);

            return mapper.Map<AdminSendMessageSummaryDTO>(data);

        }

        // add a course
        public static AdminSendMessageSummaryDTO Add(AdminSendMessageDTO dto)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminSendMessageDTO, AdminSendMessage>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<AdminSendMessage>(dto);

            var ret = DataAccessFactory.AdminSendMessageDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        // Delete a course
        public static AdminSendMessageDTO Delete(int Id)
        {
            var data = DataAccessFactory.AdminSendMessageDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminSendMessage, AdminSendMessageDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<AdminSendMessageDTO>(data);
        }

        public static AdminSendMessageSummaryDTO Update(AdminSendMessageDTO dto)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminSendMessageDTO, AdminSendMessage>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<AdminSendMessage>(dto);

            var ret = DataAccessFactory.AdminSendMessageDataAccess().Update(dbObj);

            return Get(ret.Id);

        }




    }
}
