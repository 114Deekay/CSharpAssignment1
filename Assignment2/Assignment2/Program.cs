using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new HRandDeveloper();
            Console.WriteLine("Enter the Id, Name, Designation and Joining date of the Employee respectively");
            emp.Id = int.Parse(Console.ReadLine());
            emp.Name = Console.ReadLine();
            emp.Designation = Console.ReadLine();
            emp.DateOfJoin = Console.ReadLine();

            Console.WriteLine("Total Salary = "+emp.CalculateSalary());
            Console.ReadKey();


        }
    }
}
