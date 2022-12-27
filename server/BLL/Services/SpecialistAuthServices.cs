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
    public class SpecialistAuthServices
    {
        static SpecialistAuthServices()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SpecialistDTO, Specialist>();
                cfg.CreateMap<Specialist, SpecialistDTO>();
            });
            var mapper = new Mapper(config);
        }

        public static SpecialistTokenDTO Authenticate(SpecialistDTO user)
        {


            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SpecialistDTO, Specialist>();
                cfg.CreateMap<Specialist, SpecialistDTO>();
                cfg.CreateMap<SpecialistTokenDTO, SpecialistToken>();
                cfg.CreateMap<SpecialistToken, SpecialistTokenDTO>();
            }
            );

            var mapper = new Mapper(config);



            var data = mapper.Map<Specialist>(user);

            var result = DataAccessFactory.SpecialistAuthDataAccess().Authenticate(data);
            var token = mapper.Map<SpecialistTokenDTO>(result);
            return token;
        }

        public static bool Verified(SpecialistDTO user)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SpecialistDTO, Specialist>();
                cfg.CreateMap<Specialist, SpecialistDTO>();
                cfg.CreateMap<SpecialistTokenDTO, SpecialistToken>();
                cfg.CreateMap<SpecialistToken, SpecialistTokenDTO>();
            }
            );

            var mapper = new Mapper(config);



            var data = mapper.Map<Specialist>(user);

            var result = DataAccessFactory.SpecialistAuthDataAccess().Verfied(data);
            
            return result;
        }

        public static bool IsAuthenticated(string token)
        {
            var rs = DataAccessFactory.SpecialistAuthDataAccess().IsAuthenticated(token);
            return rs;
        }
    }
}
