using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentTeacher.Core.Models;

namespace StudentTeacher.Repo.Data
{
    public class TeacherData : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(
                    new Teacher
                    {
                        Id = 1,
                        Name = "Ehueriken",
                        Subject = "Maths"
                    },
                    new Teacher
                    {
                        Id = 2,
                        Name = "Femi",
                        Subject = "English"
                    },
                    new Teacher { 
                        Id = 3,
                        Name ="Chuks",
                        Subject = "Computer Education"
                        }

                );
        }
    }
}
