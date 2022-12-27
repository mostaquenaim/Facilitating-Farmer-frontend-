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
    public class SpecialistServices
    {
        public static List<SpecialistDTO> Get()
        {
            var data = DataAccessFactory.SpecialistDataAccess().Get();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Specialist, SpecialistDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<List<SpecialistDTO>>(data);

        }

        public static SpecialistDTO Get(int Id)
        {
            var data = DataAccessFactory.SpecialistDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Specialist, SpecialistDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<SpecialistDTO>(data);
        }

        public static SpecialistDTO Add(SpecialistDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SpecialistDTO, Specialist>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Specialist>(dto);

            var ret = DataAccessFactory.SpecialistDataAccess().Add(dbObj);

            return Get(ret.Id);
        }

        public static SpecialistDTO Delete(int Id)
        {
            var data = DataAccessFactory.SpecialistDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Specialist, SpecialistDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<SpecialistDTO>(data);
        }

        public static SpecialistDTO Update(SpecialistDTO dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SpecialistDTO, Specialist>();
                cfg.CreateMap<Specialist, SpecialistDTO>();
            });

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Specialist>(dto);

            var ret = DataAccessFactory.SpecialistDataAccess().Update(dbObj);

            return mapper.Map<SpecialistDTO>(ret);
        }
    }
}
