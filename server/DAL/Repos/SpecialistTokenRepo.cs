using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SpecialistTokenRepo : Repo, IRepo<SpecialistToken>
    {
        public SpecialistToken Add(SpecialistToken obj)
        {
            db.SpecialistTokens.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public SpecialistToken Delete(int Id)
        {
            var adminObj = Get(Id);

            if (adminObj == null) return null;

            db.SpecialistTokens.Remove(adminObj);

            if (db.SaveChanges() > 0) return adminObj;

            return null;
        }

        public List<SpecialistToken> Get()
        {
            return db.SpecialistTokens.ToList();
        }

        public SpecialistToken Get(int Id)
        {
            return db.SpecialistTokens.Find(Id);
        }

        public SpecialistToken Update(SpecialistToken obj)
        {
            var dbObj = Get(obj.ID);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
