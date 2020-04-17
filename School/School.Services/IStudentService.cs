using System.Collections.Generic;
using School.Models;

namespace School.Services
{
    public interface IStudentService
    {
        IList<Student> GetStudents(int pageIndex, int pageSize, string searchText, string sortText);
    }
}