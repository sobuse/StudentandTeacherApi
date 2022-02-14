﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Core.DTos
{
    public class StudentDTo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Class { get; set; }
    }

    public class StudentCreationDto : StudentAddUpdateDto
    {

    }

    public abstract class StudentAddUpdateDto
    {
        [Required(ErrorMessage = "Student name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Class is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string? Class { get; set; }
    }
}
