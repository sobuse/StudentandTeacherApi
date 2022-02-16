using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Core.Models
{
    public  class Student
    {   [Column("StudentId")]
        public int Id { get; set; }

        [Required(ErrorMessage="Student name is required.")]
        [MaxLength(30, ErrorMessage = "Maximum Lenght for the  is 30 character")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Student class is required.")]
        [MaxLength(30, ErrorMessage= "Maximum Lenght for the  is 30 character")]
        public string Class { get; set; }

       
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
