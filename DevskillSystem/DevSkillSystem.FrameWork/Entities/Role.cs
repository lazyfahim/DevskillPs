using System.Collections.Generic;

namespace DevSkillSystem.FrameWork.Entities
{
    public class Role:Entity
    {
        public Role()
        {
            this.UserRoles = new List<UserRole>();
        }
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}