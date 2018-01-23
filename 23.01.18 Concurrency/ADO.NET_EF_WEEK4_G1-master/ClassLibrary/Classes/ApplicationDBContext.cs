using ClassLibrary.Configurations;
using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Interpreter> Interpreters { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<InterpreterLanguageKnowledge> ILKs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Husband> Husbands { get; set; }
        public DbSet<Wife> Wives { get; set; }
        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InterpreterConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new InterpreterLanguageKnowledgeConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new HusbandConfiguration());
            modelBuilder.Configurations.Add(new WifeConfiguration());
            modelBuilder.Configurations.Add(new ComputerConfiguration());

            modelBuilder.ComplexType<Monitor>();
            modelBuilder.ComplexType<SystemBlock>();

            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDbContext() : base("name=ConnectionString")
        {

        }
    }
}
