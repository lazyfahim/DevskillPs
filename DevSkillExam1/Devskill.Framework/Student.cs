using System.Collections;
using System.Collections.Generic;
using Devskill.Data;

namespace Devskill.Framework
{
    public class Student:IEntity<int>
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public ICollection<Grade> Grades { get; set; } 
    }
}