using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class HRandDeveloper:Employee
    {
        public override int CalculateSalary()
        {
            basic = 8000;

            int totalSalary= base.CalculateSalary();

            if(string.Equals(Designation,"HR",StringComparison.InvariantCultureIgnoreCase))
            {
                Experience = 4;
                totalSalary +=Experience * 1000;
            }
            if (string.Equals(Designation, "Developer", StringComparison.InvariantCultureIgnoreCase))
            {
                Experience = 5;
                totalSalary +=Experience * 2000;
            }

            return totalSalary;

        }
    }
}
