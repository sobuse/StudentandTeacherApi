using Microsoft.EntityFrameworkCore;
using StudentTeacher.Core.DTos;
using StudentTeacher.Core.Models;
using StudentTeacher.Repo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Repo
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherDto());

            modelBuilder.ApplyConfiguration(new StudentData());
        }

        public DbSet<Teacher> TeacherS { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
