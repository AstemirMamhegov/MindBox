using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject.Model
{
    public class Qualification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public DateTime Date { get; set; }
        public string IDReg { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
