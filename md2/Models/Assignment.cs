using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2.Models
{
    public class Assignment
    {
        public DateTime Deadline { get; set; }
        public Course Course { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Deadline: {Deadline.ToShortDateString()}, Course: {Course?.Name}, Description: {Description}";
        }
    }
}