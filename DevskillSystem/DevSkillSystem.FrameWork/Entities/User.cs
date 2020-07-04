using System.Collections.Generic;
using DevskillSystem.data;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevSkillSystem.FrameWork.Entities
{
    public class User:IEntity<int>
    {
        public User()
        {
            this.UserRoles = new List<UserRole>();
        }
        public string Password { get; set; }
        public string UserName { get; set; }

        public virtual Employee Employee { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public int Id { get; set; }
    }
}