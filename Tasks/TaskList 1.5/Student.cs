using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList_1._5
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }      
        public int Age { get; set; }
        public string Specialty { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}, Age: {Age}, Specialty: {Specialty}";
        }



    }
}
