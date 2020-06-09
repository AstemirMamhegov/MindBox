using CathedraProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    public class DBController
    {
        private static DBController instance = new DBController();
        private CathedraContext cathedraContext = new CathedraContext();

        public static DBController Instance
        {
            get
            {
                return instance;
            }
        }

        private DBController() { }

        public List<Country> Countries => cathedraContext.Countries.ToList();

        public void Update(Country country)
        {
            if (country.Id == 0)
                cathedraContext.Countries.Add(country);
            cathedraContext.SaveChanges();
        }

        public void Remove(Country country)
        {
            cathedraContext.Countries.Remove(country);
            cathedraContext.SaveChanges();
        }

        public List<Direction> Directions => cathedraContext.Directions.ToList();

        public void Update(Direction direction)
        {
            if (direction.Id == 0)
                cathedraContext.Directions.Add(direction);
            cathedraContext.SaveChanges();
        }

        public void Remove(Direction direction)
        {
            cathedraContext.Directions.Remove(direction);
            cathedraContext.SaveChanges();
        }

        public List<Post> Posts => cathedraContext.Posts.ToList();

        public void Update(Post post)
        {
            if (post.Id == 0)
                cathedraContext.Posts.Add(post);
            cathedraContext.SaveChanges();
        }

        public void Remove(Post post)
        {
            cathedraContext.Posts.Remove(post);
            cathedraContext.SaveChanges();
        }

        public List<Group> Groups => cathedraContext.Groups.ToList();

        public void Update(Group group)
        {
            if (group.Id == 0)
                cathedraContext.Groups.Add(group);
            cathedraContext.SaveChanges();
        }

        public void Remove(Group group)
        {
            cathedraContext.Groups.Remove(group);
            cathedraContext.SaveChanges();
        }

        public List<Subject> Subjects => cathedraContext.Subjects.ToList();

        public void Update(Subject subject)
        {
            if (subject.Id == 0)
                cathedraContext.Subjects.Add(subject);
            cathedraContext.SaveChanges();
        }

        public void Remove(Subject subject)
        {
            cathedraContext.Subjects.Remove(subject);
            cathedraContext.SaveChanges();
        }

        public List<Teacher> Teachers => cathedraContext.Teachers.ToList();

        public void Update(Teacher teacher)
        {
            if (teacher.Id == 0)
                cathedraContext.Teachers.Add(teacher);
            cathedraContext.SaveChanges();
        }

        public void Remove(Teacher teacher)
        {
            cathedraContext.Teachers.Remove(teacher);
            cathedraContext.SaveChanges();
        }

        public List<Student> Students => cathedraContext.Students.ToList();

        public void Update(Student student)
        {
            if (student.Id == 0)
                cathedraContext.Students.Add(student);
            cathedraContext.SaveChanges();
        }

        public void Remove(Student student)
        {
            cathedraContext.Students.Remove(student);
            cathedraContext.SaveChanges();
        }

        public List<StudentMark> StudentMarks => cathedraContext.StudentMarks.ToList();

        public void Update(StudentMark studentMark)
        {
            if (studentMark.Id == 0)
                cathedraContext.StudentMarks.Add(studentMark);
            cathedraContext.SaveChanges();
        }

        public void Remove(StudentMark studentMark)
        {
            cathedraContext.StudentMarks.Remove(studentMark);
            cathedraContext.SaveChanges();
        }
        public List<StudentWork> StudentWorks => cathedraContext.StudentWorks.ToList();

        public void Update(StudentWork studentWork)
        {
            if (studentWork.Id == 0)
                cathedraContext.StudentWorks.Add(studentWork);
            cathedraContext.SaveChanges();
        }

        public void Remove(StudentWork studentWork)
        {
            cathedraContext.StudentWorks.Remove(studentWork);
            cathedraContext.SaveChanges();
        }

        public List<Status> Statuses => cathedraContext.Statuses.ToList();

        public void Update(Status status)
        {
            if (status.Id == 0)
                cathedraContext.Statuses.Add(status);
            cathedraContext.SaveChanges();
        }

        public void Remove(Status status)
        {
            cathedraContext.Statuses.Remove(status);
            cathedraContext.SaveChanges();
        }

    }
}
