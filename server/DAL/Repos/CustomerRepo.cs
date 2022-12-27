using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer>,ICustAuth
    {
        public Customer Add(Customer obj)
        {
            db.Customers.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int Id)
        {
            return db.Customers.Find(Id);
        }

        public Customer Delete(int id)
        {
            var CustomerObj = Get(id);

            if (CustomerObj == null) return null;

            db.Customers.Remove(CustomerObj);

            if (db.SaveChanges() > 0) return CustomerObj;

            return null;
        }


        public Customer Update(Customer obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public CustomerToken Authenticate(Customer user)
        {
            
            var u = db.Customers.FirstOrDefault(en=>en.Username.Equals(user.Username)&& en.Password.Equals(user.Password));
            CustomerToken t = null; 
            if (u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString(); // unique random string generate
                t = new CustomerToken();
                t.CustomerId = u.Id;
                t.TokenKey = token;
                t.CreatedAt = DateTime.Now;
                db.SaveChanges();

            }
            return t;

        }

        public bool IsAuthenticated(string token)
        {
           var rs = db.CustomerTokens.Any(t => t.TokenKey.Equals(token) && t.ExpiredAt==null);
            return rs;
        }

        public void Logout(string token)
        {
            throw new NotImplementedException();
        }
    }
}
