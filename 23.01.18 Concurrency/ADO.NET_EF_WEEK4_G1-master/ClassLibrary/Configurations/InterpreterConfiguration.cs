using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class InterpreterConfiguration : EntityTypeConfiguration<Interpreter>
    {
        public InterpreterConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.FirstName).IsRequired();
            Property(p => p.FirstName).HasMaxLength(100);
        }
    }
}
