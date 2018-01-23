using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UserInGroupHistory
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public int UserGroupsRecordId { get; set; }
        public UsersGroups UsersGroupsRecord { get; set; }
    }
}
