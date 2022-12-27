using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AnswerRepo : Repo, IRepo<Answer>
    {
        public Answer Add(Answer obj)
        {
            db.Answers.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<Answer> Get()
        {
            return db.Answers.ToList();
        }

        public Answer Get(int Id)
        {
            return db.Answers.Find(Id);
        }

        public Answer Delete(int id)
        {
            var AnswerObj = Get(id);

            if (AnswerObj == null) return null;

            db.Answers.Remove(AnswerObj);

            if (db.SaveChanges() > 0) return AnswerObj;

            return null;
        }


        public Answer Update(Answer obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
