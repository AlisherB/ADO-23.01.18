using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class UserInGroupHistoryConfiguration : EntityTypeConfiguration<UserInGroupHistory>
    {
        public UserInGroupHistoryConfiguration()
        {
            HasKey(p => p.Id);
        }
    }
}
