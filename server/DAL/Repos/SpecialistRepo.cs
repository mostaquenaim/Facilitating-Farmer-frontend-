using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SpecialistRepo : Repo, IRepo<Specialist>, ISpecAuth
    {
        public Specialist Add(Specialist obj)
        {
            db.Specialists.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;

        }

        public SpecialistToken Authenticate(Specialist user)
        {
            var u = db.Specialists.FirstOrDefault(en => en.Username.Equals(user.Username) && en.Password.Equals(user.Password));
            SpecialistToken t = null;
            if (u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString(); // unique random string generate
                t = new SpecialistToken();
                t.SpecialistId = u.Id;
                t.TokenKey = token;
                t.CreatedAt = DateTime.Now;
                db.SaveChanges();

            }
            return t;
        }

        public Specialist Delete(int Id)
        {
            var specialist = Get(Id);

            db.Specialists.Remove(specialist);

            if (db.SaveChanges() > 0) return specialist;

            return null;
        }

        public List<Specialist> Get()
        {
            return db.Specialists.ToList();
        }

        public Specialist Get(int Id)
        {
            return db.Specialists.Find(Id);
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.SpecialistTokens.Any(t => t.TokenKey.Equals(token) && t.ExpiredAt == null);
            return rs;
        }

        public bool Verfied(Specialist user)
        {

            var username = user.Username;
            var users = db.Specialists.FirstOrDefault(en => en.Username.Equals(username));

            if(users == null) return false;

            if (user.Password != users.Password || users.Verified != 1) return false;

            return true;
            
            
           
        }

        public void Logout(string token)
        {
            throw new NotImplementedException();
        }

        public Specialist Update(Specialist obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
