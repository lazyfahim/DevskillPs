using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevSkillSystem.FrameWork.Entities
{
    public class User:Entity
    {
        public User()
        {
            this.UserRoles = new List<UserRole>();
        }
        public string Password { get; set; }
        public string UserName { get; set; }

        public virtual Employee Employee { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}