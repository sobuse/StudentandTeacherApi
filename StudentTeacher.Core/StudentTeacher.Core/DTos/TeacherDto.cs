using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Core.DTos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
    public class TeacherCreationDto : TeacherAddAndUpdateDto
    {
    }

    public class TeacherUpdateDto : TeacherAddAndUpdateDto
    {
    }


    public abstract class TeacherAddAndUpdateDto
    {
        [Required(ErrorMessage = "Teacher name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string? Name { get; set; }
    }
