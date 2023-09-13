using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class WorkHours
    {
        public WorkHours()
        {
            Morning = new Patient();
            Afternon = new Patient();
            Evening = new Patient();
        }
        public WorkHours(Patient morning, Patient afternon, Patient evening)
        {
            Morning = morning;
            Afternon = afternon;
            Evening = evening;
        }
      

        public Patient Morning { get; set; }
        public Patient Afternon { get; set; }
        public Patient Evening { get; set; }
    }
}
