using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory 
    {
        public static IRepo<Course> CourseDataAccess()
        {
            return new CourseRepo();
        }

        public static IRepo<Difficulty> DifficultyDataAccess()
        {
            return new DifficultyRepo();
        }

        public static IRepo<Category> CategoryDataAccess()
        {
            return new CategoryRepo();
        }

        public static IRepo<Specialist> SpecialistDataAccess()
        {
            return new SpecialistRepo();
        }

        public static IRepo<Customer> CustomerDataAccess()
        {
            return new CustomerRepo();
        }
        public static IRepo<CourseEnrollment> CourseEnrollmentDataAccess()
        {
            return new CourseEnrollmentRepo();
        }
        public static IRepo<Question> QuestionDataAccess()
        {
            return new QuestionRepo();
        }
        public static IRepo<Answer> AnswerDataAccess()
        {
            return new AnswerRepo();
        }
        public static IRepo<Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }

        public static IRepo<AdminSendMessage> AdminSendMessageDataAccess()
        {
            return new AdminSendMessageRepo();
        }

        public static ITokenRepo<CustomerToken> CustomerTokensDataAccess()
        {
            return new CustomerTokenRepo();
        }

        public static ICustAuth CustomerAuthDataAccess()
        {
            return new CustomerRepo();
        }
        public static IAdminAuth AdminAuthDataAccess()
        {
            return new AdminRepo();
        }
        public static ISpecAuth SpecialistAuthDataAccess()
        {
            return new SpecialistRepo();
        }


    }
}
