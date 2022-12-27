using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepo : Repo, IRepo<Category>
    {
        public Category Add(Category obj)
        {
            db.Categories.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public Category Delete(int id)
        {
            var catObj = Get(id);

            if (catObj == null) return null;

            db.Categories.Remove(catObj);

            if (db.SaveChanges() > 0) return catObj;

            return null;
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public Category Update(Category obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
