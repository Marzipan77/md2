using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2.Models
{
    public abstract class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get => name;
            set
            {
                // Pārbauda, vai jaunā vērtība nav tukša
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                // Pārbauda, vai jaunā vērtība nav tukša
                if (!string.IsNullOrWhiteSpace(value))
                {
                    surname = value;
                }
            }
        }

        // Tikai lasāma īpašība, kas atgriež pilno vārdu un uzvārdu
        public string FullName => $"{Name} {Surname}";

        public GenderType Gender { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Gender: {Gender}";
        }
    }
}
