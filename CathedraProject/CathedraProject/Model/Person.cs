using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    [Table("Person")]
    public abstract class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address FactAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Sex Sex { get; set; }
        public string StatusFamily { get; set; }
        
        public string Education { get; set; }

        public string FIO
        {
            get
            {
                return $"{LastName} {FirstName} {MiddleName}";
            }
        }

        public virtual Parent Mother { get; set; }
        public virtual Parent Father { get; set; }

        public virtual List<Person> Children { get; set; } = new List<Person>();

        public override string ToString()
        {
            return FIO;
        }

        public string SexString
        {
            get
            {
                switch (Sex)
                {
                    case Sex.Male:
                        return "Мужской";
                    case Sex.Female:
                        return "Женский";
                }
                return "Неизвестно";
            }
        }
    }
}
