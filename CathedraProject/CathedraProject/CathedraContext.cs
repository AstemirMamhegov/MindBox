using CathedraProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    public class CathedraContext : DbContext
    {
        static CathedraContext()
        {
            Database.SetInitializer(new MyContextInitializer());
        }

        public CathedraContext() : base("DBConnection")
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentMark> StudentMarks { get; set; }
        public DbSet<StudentWork> StudentWorks { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
