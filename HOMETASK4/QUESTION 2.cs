using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_4
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;
        public Employee(int employeeID,string name,string department,double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Department = department;
            Salary = salary;
        }
        void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee details are displayed here : ");
            Console.WriteLine($"EmployeeID : {EmployeeID}");
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Employee's Department : {Department}");
            Console.WriteLine($"Employee's Salary : {Salary}");
        }
        void IncreaseSalary(double amount)
        {
            if(amount< 0)
            {
                Console.WriteLine("The amount must be positive value");
                return;
            }
            Salary = Salary + amount;
        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(125,"Khadija","Aviation",765890);
            employee1.EmployeeID = 125;
            employee1.Name = "Khadija";
            employee1.Department = "Aviation";
            employee1.Salary = 765890;

            employee1.DisplayEmployeeDetails();
            employee1.IncreaseSalary(45667);
            Console.WriteLine("\n After increasing salary : \n");
            employee1.DisplayEmployeeDetails();

        }
    }
}
