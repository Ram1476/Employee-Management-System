using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Console.Write("\nEnter The Number of Employee Details You Want to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            Employee_System employees = new Employee_System();

            int i = 0;
            while (i < Count)
            {

                Console.Write("\nEnter the Employee_ID: ");
                employees.employee_Id = int.Parse(Console.ReadLine());

                Console.Write("\nEnter Employee_Name: ");
                employees.employee_Name = Console.ReadLine();

                Console.Write("\nEnter Employee DateOfBirth: ");
                employees.employee_DOB = DateTime.Parse(Console.ReadLine());

                Console.Write("\nEnter Employee_Salary: ");
                employees.employee_Salary = double.Parse(Console.ReadLine());

                Console.Write("\nEnter Employee_Active Status: ");
                string user_Input = Console.ReadLine();
                if (user_Input != null && user_Input.ToUpper() == "Y")
                {
                    employees.employee_Active_Status = true;
                }
                else
                {
                    employees.employee_Active_Status = false;
                }
                Console.WriteLine("\nYour Employee data Has been Successfully Created");

                i++;
            }


            return employees;

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
                Console.WriteLine("\n******************************");
                Console.WriteLine("\n Your Preferred Employee Details Is Been updated\n\nThank You using the Employee Management System");
                Console.WriteLine("\n******************************");
            }
            else
            {
                Console.WriteLine("\nEnter a Valid Employee detail");
            }
        }

        public void view_Employee(ref ArrayList employeeList)
        {
            bool isDataupdated = false;
            Employee_System employee = new Employee_System();
            Console.Write("\nEnter the Employee_ID Your Want to View: ");
            //int Employee_Id = int.Parse(Console.ReadLine());
            int Employee_Id = 0;
            if (int.TryParse(Console.ReadLine(), out Employee_Id))
            {

                foreach (Employee_System emp in employeeList)
                {
                    if (emp.employee_Id == Employee_Id)
                    {
                        Console.WriteLine($"Employee ID :{emp.employee_Id}");
                        Console.WriteLine($"Employee Name:{emp.employee_Name}");
                        Console.WriteLine($"Employee DOB:{emp.employee_DOB}");
                        Console.WriteLine($"Employee Salary:{emp.employee_Salary}");
                        Console.WriteLine($"Employee Active-Status:{emp.employee_Active_Status}");
                        isDataupdated = true;
                    }
                    break;

                }
            }
           
            if (isDataupdated)
            {

                Console.WriteLine("\nYour Employee Details Displayed Successfully");
            }
            else 
            {
                Console.WriteLine("\nEmployee_Id you have entered Does not Exist");
            }
        }

        public void Delete_Employee(ref ArrayList employeeList) 
        {
            bool isDataDeleted = false;
            Employee_System employee = new Employee_System();
            Console.Write("\nEnter the Employee_ID You Want to Delete: ");
            int Employee_Id = int.Parse(Console.ReadLine());

            foreach(Employee_System emp in employeeList) 
            {
                if (emp.employee_Id == Employee_Id) 
                {
                    isDataDeleted= true;
                    employeeList.Remove(emp);
                    break;
                }   
            }
            if (!isDataDeleted) 
            {
                Console.WriteLine("\n******** Your Preferred Employee_Id has Been Deleted Successfully ********");
            }
            else 
            {
                Console.WriteLine("Employee Info Does not exist ");
            }
        }

        public void ViewAll_Employee(ref ArrayList employeeList) 
        {
            if (employeeList.Count > 0)
            {
                foreach (Employee_System emp in employeeList)
                {
                    Console.WriteLine($"Employee ID :{emp.employee_Id}");
                    Console.WriteLine($"Employee Name:{emp.employee_Name}");
                    Console.WriteLine($"Employee DOB:{emp.employee_DOB}");
                    Console.WriteLine($"Employee Salary:{emp.employee_Salary}");
                    Console.WriteLine($"Employee Active-Status:{emp.employee_Active_Status}");
                    Console.WriteLine("\n");
                }
            }
            else 
            {
                Console.WriteLine("Employee's List is Empty");
            }
        }

    }
}
