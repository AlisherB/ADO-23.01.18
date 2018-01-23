using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UsersGroups
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public DateTime EnteredDate { get; set; }
        public bool IsActiveMember { get; set; }
        public virtual User User { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<UserInGroupHistory> RoleHistory { get; set; }
    }
}
