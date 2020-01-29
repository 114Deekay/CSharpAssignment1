using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter th Id, Name and Department of the Employee, respectively");
            string id = Console.ReadLine();
            string name = Console.ReadLine();
            string deptName = Console.ReadLine();

            Employee emp = new Employee(id, name, deptName);
            emp.FunctionCall += new FunctionCallDelegate(OnFunctionCall);
            emp.FunctionCall += new FunctionCallDelegate(OnFunctionCall2);
            emp.FunctionCall += new FunctionCallDelegate(OnFunctionCall3);

            Console.WriteLine("Employee Id = "+emp.GetId());
            Console.WriteLine("Employee Name = " + emp.GetName());
            Console.WriteLine("Employee Department = " + emp.GetDeparmentName());
            Console.ReadKey();
            
           
        }
        public static string OnFunctionCall()
        {
            return "GetId() Called";
        }

        public static string OnFunctionCall2()
        {
            return "GetName() Called";
        }

        public static string OnFunctionCall3()
        {
            return "GetDepartmentName() Called";
        }

    }
}
