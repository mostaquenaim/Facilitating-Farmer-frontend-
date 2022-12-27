using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseEnrollmentRepo : Repo, IRepo<CourseEnrollment>
    {
        public CourseEnrollment Add(CourseEnrollment obj)
        {
            db.CourseEnrollments.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<CourseEnrollment> Get()
        {
            return db.CourseEnrollments.ToList();
        }

        public CourseEnrollment Get(int Id)
        {
            return db.CourseEnrollments.Find(Id);
        }

        public CourseEnrollment Delete(int id)
        {
            var CourseEnrollmentObj = Get(id);

            if (CourseEnrollmentObj == null) return null;

            db.CourseEnrollments.Remove(CourseEnrollmentObj);

            if (db.SaveChanges() > 0) return CourseEnrollmentObj;

            return null;
        }


        public CourseEnrollment Update(CourseEnrollment obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }

}
