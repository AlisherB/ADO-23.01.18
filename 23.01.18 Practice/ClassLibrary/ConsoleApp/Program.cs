using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ClassLibrary.Configurations;
using ClassLibrary.Migrations;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDBContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDBContext, Configuration>());

            using (ApplicationDBContext dbContext = new ApplicationDBContext())
            {
                var userOne = new User()
                {
                    Name = "Alisher"
                };
                var groupOne = new Group()
                {
                    Name = "SHAG IN VK"
                };
                dbContext.Users.Add(userOne);
                dbContext.Groups.Add(groupOne);
                dbContext.SaveChanges();

                var recordOfEntry = new UsersGroups()
                {
                    UserId = userOne.Id,
                    GroupId = groupOne.Id,
                    IsActiveMember = true,
                    EnteredDate = DateTime.Now,
                    RoleHistory = new List<UserInGroupHistory>
                    {
                        new UserInGroupHistory()
                        {
                            RoleName = "Student"
                        }
                    }
                };

                dbContext.UsersInGroups.Add(recordOfEntry);
                dbContext.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
