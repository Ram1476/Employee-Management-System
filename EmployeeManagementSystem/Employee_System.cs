using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSystem
{
    internal class Employee_System
    {
        public int employee_Id { get; set; }
        public string employee_Name { get; set; }

        public DateTime employee_DOB { get; set; }

        public double employee_Salary { get; set; }

        public bool employee_Active_Status { get; set; }

        //ArrayList Employee_Details = new ArrayList();

        public Employee_System Create_Employee()
        {
            Console.Write("Enter The Number of Employee Details You Want to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            Employee_System employee = new Employee_System();

            int i = 0;
            while (i < Count)
            {

                Console.Write("\nEnter the Employee_ID: ");
                employee.employee_Id = int.Parse(Console.ReadLine());

                Console.Write("\nEnter Employee_Name: ");
                employee.employee_Name = Console.ReadLine();

                Console.Write("\nEnter Employee DateOfBirth: ");
                employee.employee_DOB = DateTime.Parse(Console.ReadLine());

                Console.Write("\nEnter Employee_Salary: ");
                employee.employee_Salary = double.Parse(Console.ReadLine());

                Console.Write("\nEnter Employee_Active Status: ");
                string user_Input = Console.ReadLine();
                if (user_Input != null && user_Input.ToUpper() == "Y")
                {
                    employee.employee_Active_Status = true;
                }
                else
                {
                    employee.employee_Active_Status = false;
                }
                Console.WriteLine("\nYou Employee data Has been Successfully Created");

                i++;
            }


            return employee;

        }

        public void Update_Employee(ref ArrayList employeeList)
        {
            bool isDataupdated = false;
            Employee_System employee = new Employee_System();
            Console.Write("\nEnter the Employee_ID Your Want to Update: ");
            employee.employee_Id = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Salary Value Need to be Updated: ");
            employee.employee_Salary = double.Parse(Console.ReadLine());
            foreach (Employee_System emp in employeeList)
            {
                if (emp.employee_Id == employee.employee_Id)
                {
                    emp.employee_Salary = employee.employee_Salary;
                    isDataupdated = true;
                    break;
                }
            }
            if (isDataupdated)
            {
                Console.WriteLine("\n******************");
                Console.WriteLine("\n Your Preferred Employee Details Is Been updated\nThank You using the Employee Management System");
                Console.WriteLine("\n******************");
            }
            else
            {
                Console.WriteLine("Enter a Valid Employee detail");
            }
        }

        public void view_Employee(ref ArrayList employeeList)
        {

        }


    }
}
