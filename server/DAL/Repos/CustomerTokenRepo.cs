using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerTokenRepo : Repo, ITokenRepo<CustomerToken>
    {
        public CustomerToken Add(CustomerToken obj)
        {
            db.CustomerTokens.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public CustomerToken Delete(int Id)
        {
            var adminObj = Get(Id);

            if (adminObj == null) return null;

            db.CustomerTokens.Remove(adminObj);

            if (db.SaveChanges() > 0) return adminObj;

            return null;
        }

        public List<CustomerToken> Get()
        {
            return db.CustomerTokens.ToList();
        }

        public CustomerToken Get(int Id)
        {
            return db.CustomerTokens.Find(Id);
        }

        public CustomerToken Get(string Id)
        {
            return db.CustomerTokens.FirstOrDefault(t => t.TokenKey.Equals(Id));
        }

        

        public CustomerToken Update(CustomerToken obj)
        {
            var dbObj = Get(obj.ID);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }


    }
}
