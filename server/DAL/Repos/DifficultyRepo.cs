using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DifficultyRepo : Repo, IRepo<Difficulty>
    {
        public Difficulty Add(Difficulty obj)
        {
            db.Difficulties.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public Difficulty Delete(int id)
        { 
            var dbObj = Get(id);

            db.Difficulties.Remove(dbObj);

            if (db.SaveChanges() > 0) return dbObj;

            return null;
        }

        public List<Difficulty> Get()
        {
            return db.Difficulties.ToList();
        }

        public Difficulty Get(int id)
        {
            return db.Difficulties.Find(id);
        }

        public Difficulty Update(Difficulty obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
