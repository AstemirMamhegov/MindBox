using CathedraProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    [Table("Student")]
    public class Student : Person
    {
        public virtual Direction Direction { get; set; }
        public virtual Group Group { get; set; }
        public int Course { get; set; }

        public DateTime CreateDate { get; set; }
        public string PlaceWork { get; set; }
        public string Activity { get; set; }
        public virtual Status Status { get; set; }

        public virtual List<StudentMark> Marks { get; set; } = new List<StudentMark>();

        public virtual List<StudentWork> StudentWorks { get; set; } = new List<StudentWork>();
    }
}
