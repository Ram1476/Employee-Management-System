using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_System user1 = new Employee_System();
            string user_Choice = "";
            ArrayList employee = new ArrayList();
            Console.WriteLine("****** Welcome to the Employee Management System ******");
            Console.WriteLine("\n******************************");

            Console.WriteLine("\n1.To Create New Employee Data\n2.To Update Employee Data\n3. Delete Employee data\n4.View All Employee data\n5.View Employee data with selete ID");
            Console.WriteLine("\n******************************");

            Console.Write("\nEnter the Number Corresponding to the function you Want to execute:");



            while (user_Choice.ToUpper() != "QUIT")
            {
                user_Choice = Console.ReadLine();

                switch (user_Choice)
                {
                    case "1":
                        employee.Add(user1.Create_Employee());
                        break;
                    case "2":
                        user1.Update_Employee(ref employee);
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Input To Continue:");
                        break;
                        //case "3":
                        //    user

                }
                Console.Write("\nEnter the Value for the next function if u want to continue or Enter \'Quit\' to End this Session: ");
                user_Choice = Console.ReadLine();
            }
            Console.WriteLine("\n****** Thank You For Using the Employee Management System ****** ");
            Console.ReadLine();

        }
    }
}
