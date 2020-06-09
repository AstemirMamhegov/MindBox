using CathedraProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    [Table("Teacher")]
    public class Teacher : Person
    {
        public virtual Post Post { get; set; }
        public double Rate { get; set; }
        public int Experience { get; set; }

        public virtual List<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
        public virtual List<Qualification> Qualifications { get; set; } = new List<Qualification>();
    }
}
