using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class LanguageConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).IsRequired();
            Property(p => p.LanguageName).HasMaxLength(100);
        }
    }
}
