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
    public class CustomerAuthServices
    {
        static CustomerAuthServices()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
        }

        public static List<CustomerTokenDTO> Get()
        {
            var data = DataAccessFactory.CustomerTokensDataAccess().Get();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerToken, CustomerTokenDTO>();
                cfg.CreateMap<CustomerTokenDTO, CustomerToken>();
               
            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CustomerTokenDTO>>(data);

        }

        public static CustomerTokenDTO Authenticate(CustomerDTO user)
        {
            

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
                cfg.CreateMap<CustomerTokenDTO, CustomerToken>();
                cfg.CreateMap<CustomerToken, CustomerTokenDTO>();
            }
            );

            var mapper = new Mapper(config);
            

            
            var data = mapper.Map<Customer>(user);

            var result= DataAccessFactory.CustomerAuthDataAccess().Authenticate(data);
            var token= mapper.Map<CustomerTokenDTO>(result);
            return token;
        }

        public static bool IsAuthenticated(string token)
        {
            var rs = DataAccessFactory.CustomerAuthDataAccess().IsAuthenticated(token);
            return rs;
        }

        public static bool TokenValidity(string token)
        {
            var tk = DataAccessFactory.CustomerTokensDataAccess().Get(token);
            if (tk != null && tk.ExpiredAt == null)
            {
                return true;
            }
            return false;

        }
    }
}
