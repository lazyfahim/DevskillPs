using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Autofac;
using School.Services;

namespace School.Models
{
    public class StudenModel
    {
        private IStudentService _service;
        public StudenModel()
        {
            _service = Startup.AutofacContainer.Resolve<IStudentService>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(10,ErrorMessage = "Not allowed more than 10 char")]
        public string Name { get; set; }

        [Required] [DataType(DataType.Date)] 
        public DateTime DateOfBirth { get; set; }

        public void CreateStudent(string Name, DateTime DateOfBirth)
        {
            Student student  = new Student()
            {
                Name = Name,
                DateOfBirth = DateOfBirth
            };
            _service.AddStudent(student);
        }
    }
    
}