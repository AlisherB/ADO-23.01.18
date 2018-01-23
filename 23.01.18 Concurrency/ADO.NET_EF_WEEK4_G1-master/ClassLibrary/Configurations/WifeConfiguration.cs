using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class WifeConfiguration : EntityTypeConfiguration<Wife>
    {
        public WifeConfiguration()
        {
            HasKey(p => p.WifeId);
            HasRequired(p => p.Husband)
                .WithOptional(p => p.Wife)
                .Map(p => p.MapKey("HusbandId"));
        }
    }
}
