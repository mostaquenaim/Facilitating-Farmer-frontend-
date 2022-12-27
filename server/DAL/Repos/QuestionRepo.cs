using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class QuestionRepo : Repo, IRepo<Question>
    {
        public Question Add(Question obj)
        {
            db.Questions.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<Question> Get()
        {
            return db.Questions.ToList();
        }

        public Question Get(int Id)
        {
            return db.Questions.Find(Id);
        }

        public Question Delete(int id)
        {
            var QuestionObj = Get(id);

            if (QuestionObj == null) return null;

            db.Questions.Remove(QuestionObj);

            if (db.SaveChanges() > 0) return QuestionObj;

            return null;
        }


        public Question Update(Question obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
