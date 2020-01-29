using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }

        public Employee(string id, string name, string deptName)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentName = deptName;
        
        }

        public string GetId()
        {
            FunctionCall();
            return Id;
        }

        public string GetName()
        {
            FunctionCall();
            return Name;
        }

        public string GetDeparmentName()
        {
            FunctionCall();
            return DepartmentName;
        }
        public void update(string )
        {
            
        }

        public event FunctionCallDelegate FunctionCall;




    }
}
