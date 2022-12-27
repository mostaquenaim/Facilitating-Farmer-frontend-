using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin>, IAdminAuth
    {
        public Admin Add(Admin obj)
        {
            db.Admins.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public AdminToken Authenticate(Admin user)
        {
            var u = db.Admins.FirstOrDefault(en => en.Username.Equals(user.Username) && en.Password.Equals(user.Password));
            AdminToken t = null;
            if (u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString(); // unique random string generate
                t = new AdminToken();
                t.AdminId = u.Id;
                t.TokenKey = token;
                t.CreatedAt = DateTime.Now;
                db.SaveChanges();

            }
            return t;
        }

        public Admin Delete(int Id)
        {
            var adminObj = Get(Id);

            if (adminObj == null) return null;

            db.Admins.Remove(adminObj);

            if (db.SaveChanges() > 0) return adminObj;

            return null;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int Id)
        {
            return db.Admins.Find(Id);
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.AdminTokens.Any(t => t.TokenKey.Equals(token) && t.ExpiredAt == null);
            return rs;
        }

        public void Logout(string token)
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        
    }
}
