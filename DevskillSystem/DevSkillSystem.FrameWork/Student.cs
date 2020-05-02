using System.Collections;
using System.Collections.Generic;
using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class Student:IEntity<int>
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public ICollection<Grade> Gardes { get; set; }
        public int Id { get; set; }
    }
}