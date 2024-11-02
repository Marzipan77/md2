using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2.Models
{
    public class Course
    {

        public string Name { get; set; }


        public Teacher Teacher { get; set; }


        public override string ToString()
        {

            return $"Course Name: {Name}, Teacher: {Teacher?.FullName}";
        }
    }
}