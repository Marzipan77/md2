using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2.Models
{
    public class Teacher : Person
    {
        public DateTime ContractDate { get; set; }
        public GenderType Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Gender: {Gender}, ContractDate: {ContractDate}";
        }
    }
}
