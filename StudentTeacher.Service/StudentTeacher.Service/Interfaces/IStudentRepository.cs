using StudentTeacher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Service.Interfaces
{
    internal interface IStudentRepository
    {
        Task<Student> GetStudent(int teacherId, int studentID, bool trackChanges);
        Task CraeteStudentForTeacher(int teacherId, Student student);
        Task DeleteStudent(Student student);
    }
}
