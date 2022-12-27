namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.FacilitatingFarmerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.FacilitatingFarmerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // ---------------------------------- Difficulty ------------------------------


            string[] difficulties = new string[] { "Beginner", "Intermediate", "Expert" };

            List<Difficulty> difficulties1 = new List<Difficulty>();

            foreach (var item in difficulties)
            {
                difficulties1.Add(new Difficulty
                {
                    Type = item
                });
            }

            context.Difficulties.AddOrUpdate(s => s.Type, difficulties1.ToArray());

            // ---------------------------------- Course Video Locks ------------------------------


            bool[] locks = new bool[] { true, false };

            List<CouseVideoLock> couseVideoLocks = new List<CouseVideoLock>();

            foreach (var item in locks)
            {
                couseVideoLocks.Add(new CouseVideoLock
                {
                    IsLocked = item
                });
            }

            context.CouseVideoLocks.AddOrUpdate(s => s.IsLocked, couseVideoLocks.ToArray());


            // ---------------------------------- Category ------------------------------------
            
            string[] categories = new string[] {
                "Dairy farming",
                "Commercial grain farming",
                "Plantation Farming",
                "Livestock Ranching",
                "Mediterranean Agriculture",
                "Mixed Crop and Livestock Farming",
                "Commercial Gardening and Fruit Farming",
                "Fisheries"
            };

            List<Category> categories1 = new List<Category>();

            foreach (var item in categories)
            {
                categories1.Add(new Category
                {
                    Type = item
                });
            }

            context.Categories.AddOrUpdate(s => s.Type, categories1.ToArray());



            // ---------------------------------- Courses -----------------------------------
            

           List<Course> courses = new List<Course>();
            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                courses.Add(new Course
                {
                    // Guid substring max length 32 characters
                    Title = Guid.NewGuid().ToString().Substring(0, 10),
                    Subtitle = Guid.NewGuid().ToString().Substring(1, 20),
                    Description = Guid.NewGuid().ToString().Substring(1, 30),
                    LastUpdatedAt = DateTime.Now,
                    DifficultyId = random.Next(1, 4),
                    CategoryId = random.Next(1, 9)
                });
            }

            context.Courses.AddOrUpdate(s => s.Title, courses.ToArray());

            // ---------------------------------- Customer -----------------------------------


            /*   List<Customer> customers = new List<Customer>();
               Random randcus = new Random();

               for (int i = 1; i <= 10; i++)
               {
                   customers.Add(new Customer
                   {
                       // Guid substring max length 32 characters
                       Name = Guid.NewGuid().ToString().Substring(0, 10),
                       Username = Guid.NewGuid().ToString().Substring(1, 20),
                       Email = Guid.NewGuid().ToString().Substring(1, 30),
                       Password = Guid.NewGuid().ToString().Substring(1, 30);

                   });
               }

               context.Courses.AddOrUpdate(s => s.Title, courses.ToArray()); */
        }
    }
}
