using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminTokenRepo : Repo, IRepo<AdminToken>
    {
        public AdminToken Add(AdminToken obj)
        {
            db.AdminTokens.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public AdminToken Delete(int Id)
        {
            var adminObj = Get(Id);

            if (adminObj == null) return null;

            db.AdminTokens.Remove(adminObj);

            if (db.SaveChanges() > 0) return adminObj;

            return null;
        }

        public List<AdminToken> Get()
        {
            return db.AdminTokens.ToList();
        }

        public AdminToken Get(int Id)
        {
            return db.AdminTokens.Find(Id);
        }

        public AdminToken Update(AdminToken obj)
        {
            var dbObj = Get(obj.ID);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }


    }
}
