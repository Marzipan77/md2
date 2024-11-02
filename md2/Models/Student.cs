using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2.Models
{
    public class Student : Person
    {
        public string StudentIdNumber { get; set; }
        public GenderType Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, StudentIdNumber: {StudentIdNumber}, Gender: {Gender}";
        }
    }
}
