using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class ComputerConfiguration : EntityTypeConfiguration<Computer>
    {
        public ComputerConfiguration()
        {
            HasKey(p => p.Id);
        }
    }
}
