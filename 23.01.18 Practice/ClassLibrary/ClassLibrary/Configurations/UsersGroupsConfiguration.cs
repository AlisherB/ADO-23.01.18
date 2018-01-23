using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class UsersGroupsConfiguration : EntityTypeConfiguration<UsersGroups>
    {
        public UsersGroupsConfiguration()
        {
            HasKey(p => p.Id);
            HasRequired(p => p.Group)
                .WithMany(p => p.UsersOfGroup)
                .HasForeignKey(p => p.GroupId);
            HasRequired(p => p.User)
                .WithMany(p => p.GroupsOfUser)
                .HasForeignKey(p => p.UserId);
            HasMany(p => p.RoleHistory)
                .WithRequired(p => p.UsersGroupsRecord)
                .HasForeignKey(p => p.UserGroupsRecordId);
        }
    }
}
