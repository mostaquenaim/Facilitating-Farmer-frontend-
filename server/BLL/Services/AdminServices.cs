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
    public class AdminServices
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Admin, AdminDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<AdminDTO>>(data);

        }

        // Get Admin by Id
        public static AdminDTO Get(int Id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Admin, AdminDTO>();
                
            });

            var mapper = new Mapper(config);

            return mapper.Map<AdminDTO>(data);

        }

        // add a Admin
        public static AdminDTO Add(AdminDTO dto)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminDTO, Admin>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Admin>(dto);

            var ret = DataAccessFactory.AdminDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        // Delete a Admin
        public static AdminDTO Delete(int Id)
        {
            var data = DataAccessFactory.AdminDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<AdminDTO>(data);
        }

        public static AdminDTO Update(AdminDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminDTO, Admin>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Admin>(dto);

            var ret = DataAccessFactory.AdminDataAccess().Update(dbObj);


            return Get(ret.Id);

        }



    }
}
