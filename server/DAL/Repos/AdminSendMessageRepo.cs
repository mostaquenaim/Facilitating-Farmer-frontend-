using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminSendMessageRepo : Repo, IRepo<AdminSendMessage>
    {
        public AdminSendMessage Add(AdminSendMessage obj)
        {
            db.AdminSendMessages.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public AdminSendMessage Delete(int Id)
        {
            var msgObj = Get(Id);

            if (msgObj == null) return null;

            db.AdminSendMessages.Remove(msgObj);

            if (db.SaveChanges() > 0) return msgObj;

            return null;
        }

        public List<AdminSendMessage> Get()
        {
            return db.AdminSendMessages.ToList();
        }

        public AdminSendMessage Get(int Id)
        {
            return db.AdminSendMessages.Find(Id);
        }

        public AdminSendMessage Update(AdminSendMessage obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

    }
}
