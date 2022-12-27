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
    public class CustomerServices
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerDataAccess().Get();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>();

            });

            var mapper = new Mapper(config);

            return mapper.Map<List<CustomerDTO>>(data);
        }

        // Get Customer by id
        public static CustomerDTO Get(int Id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(Id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });

            var mapper = new Mapper(config);

            return mapper.Map<CustomerDTO>(data);
        }
        //Add a customer
        public static CustomerDTO Add(CustomerDTO dto)
        {


            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, Customer>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Customer>(dto);

            var ret = DataAccessFactory.CustomerDataAccess().Add(dbObj);

            return Get(ret.Id);

        }

        // Delete a Customer
        public static CustomerDTO Delete(int Id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Delete(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());

            var mapper = new Mapper(config);

            return mapper.Map<CustomerDTO>(data);
        }
        //update a customer
        public static CustomerDTO Update(CustomerDTO dto)
        {


            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, Customer>());

            var mapper = new Mapper(config);

            var dbObj = mapper.Map<Customer>(dto);

            var ret = DataAccessFactory.CustomerDataAccess().Update(dbObj);

            return Get(ret.Id);

        }

    }
}

