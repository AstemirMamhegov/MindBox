using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    public class StudentMark
    {
        public int Id { get; set; }
        public virtual Subject Subject { get; set; }
        public int Mark { get; set; }
        public int Course { get; set; }
        public int Semestr { get; set; }
        public virtual Student Student { get; set; }
    }
}
