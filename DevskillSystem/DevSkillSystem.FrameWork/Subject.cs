using System.Collections;
using System.Collections.Generic;
using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class Subject:IEntity<int>
    {
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public int Id { get; set; }
    }
}