using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Patient
    {
        public Patient()
        {
            Name = default;
            Surname = default;
            Gmail = default;
        }
        public Patient(string name, string surname, string gmail)
        {
            Name = name;
            Surname = surname;
            Gmail = gmail;
        }
        public Patient(Patient pt)
        {
            Name = pt.Name;
            Surname = pt.Surname;
            Gmail = pt.Gmail;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gmail { get; set; }
    }
}
