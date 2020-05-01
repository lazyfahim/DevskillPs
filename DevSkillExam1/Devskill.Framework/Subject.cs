using System.Collections;
using System.Collections.Generic;
using Devskill.Data;

namespace Devskill.Framework
{
    public class Subject:IEntity<int>
    {
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public int Id { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}