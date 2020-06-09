using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    [Table("Parent")]
    public class Parent : Person
    {
        public string Work { get; set; }
        public string Position { get; set; }
        public string HomeNumb { get; set; }
    }
}
