using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Doctor
    {
        public int staticId { get; set; } = 1;
        public int Id { get; set; }

        public Doctor()
        {
            Id = staticId++;
            Name = default;
            Surname = default;
            WorkExperience = default;
            WorkHours = new WorkHours();
        }
        public Doctor(string name, string surname, int workExperience)
        {
            Id = staticId++;
            Name = name;
            Surname = surname;
            WorkExperience = workExperience;
            WorkHours = new();
        }
       public void show()
        {
            Console.WriteLine("name: "+Name);
            Console.WriteLine("Surname: "+Surname);
            Console.WriteLine("Expernce: "+WorkExperience);
        }
         public WorkHours WorkHours { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public  int WorkExperience { get; set; }

    }
}
