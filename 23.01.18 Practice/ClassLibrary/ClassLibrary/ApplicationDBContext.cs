using ClassLibrary.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UsersGroups> UsersInGroups { get; set; }
        public DbSet<UserInGroupHistory> UsersInGroupsHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new UsersGroupsConfiguration());
            modelBuilder.Configurations.Add(new UserInGroupHistoryConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDBContext() : base("name=ConnectionString")
        {

        }
    }
}
