using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class HusbandConfiguration : EntityTypeConfiguration<Husband>
    {
        public HusbandConfiguration()
        {
            HasKey(p => p.HusbandId);
        }
    }
}
