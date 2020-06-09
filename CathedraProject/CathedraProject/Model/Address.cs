using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public virtual Country Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberHouse { get; set; }
        public int NumberFlat { get; set; }
        public virtual Person Person { get; set; }

        public override string ToString()
        {
            return $"{City} {Street} {NumberHouse} - {NumberFlat}";
        }
    }
}
