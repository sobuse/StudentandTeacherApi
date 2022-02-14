using AutoMapper;
using StudentTeacher.Core.DTos;
using StudentTeacher.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Core.Mappings
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<Student, StudentDTo>();
            CreateMap<StudentCreationDto, Student>();
            CreateMap<StudentAddUpdateDto, Student>();

            CreateMap<StudentAddUpdateDto, Student>().ReverseMap();
        }
    }
}
