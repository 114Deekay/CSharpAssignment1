using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Employee
    {
        public int basic;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public int AnnualSalary
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        public string DateOfJoin { get; set; }

        public virtual int CalculateSalary()
        {
            return AnnualSalary;
        }

    }
}
