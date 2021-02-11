using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inputs;
using Company_Manager;

namespace Company_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            //Prepared employees list
            {
                HourlyEmployee hourlyEmployee = new HourlyEmployee("Bob", 30, "Male", Employee.Position.HourlyEmployee, 8, 5);
                company.AddEmployee(hourlyEmployee, 0);

                hourlyEmployee = new HourlyEmployee("John", 27, "Male", Employee.Position.HourlyEmployee, 8, 5);
                company.AddEmployee(hourlyEmployee, 0);

                hourlyEmployee = new HourlyEmployee("Gyda", 22, "Female", Employee.Position.HourlyEmployee, 8, 5);
                company.AddEmployee(hourlyEmployee, 0);

                /////////////////////////////////////////////////////////////////
                SalariedEmployee salariedEmployee = new SalariedEmployee("Arthur", 35, "Male", Employee.Position.SalariedEmployee, 15, 5);
                company.AddEmployee(salariedEmployee, 0);

                salariedEmployee = new SalariedEmployee("Cathy", 37, "Female", Employee.Position.SalariedEmployee, 15, 5);
                company.AddEmployee(salariedEmployee, 0);

                salariedEmployee = new SalariedEmployee("Isabella", 37, "Female", Employee.Position.SalariedEmployee, 15, 5);
                company.AddEmployee(salariedEmployee, 0);

                /////////////////////////////////////////////////////////////////
                Manager manager = new Manager("Michael", 40, "Male", Employee.Position.Manager, 75, 1500);
                company.AddEmployee(manager, 0);

                manager = new Manager("Alex", 41, "Male", Employee.Position.Manager, 75, 1500);
                company.AddEmployee(manager, 0);

                /////////////////////////////////////////////////////////////////
                Executive executive = new Executive("Thomas", 47, "Male", Employee.Position.Executive, 250);
                company.AddEmployee(executive, 0);
            }

            //Prepared unemployed persons list
            {
                HourlyEmployee hourlyEmployee = new HourlyEmployee("Tom", 20, "Male");
                company.RemoveEmployee(hourlyEmployee, 0);

                hourlyEmployee = new HourlyEmployee("Mike", 22, "Male");
                company.RemoveEmployee(hourlyEmployee, 0);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to the company manager!!!");
            Console.ResetColor();

            do
            {
                Menu();
                MenuPoint choice = InputMenu();
                
                if (choice == MenuPoint.Exit)
                {
                    Console.WriteLine("Close the program...");
                    Console.ReadKey();
                    break;
                }
                    
                switch (choice) 
                {
                    case MenuPoint.ShowEmployees:
                        {
                            company.ShowEmployees();
                            break;
                        }
                    case MenuPoint.ShowUnemployedPersons:
                        {
                            company.ShowUnemployedPersons();
                            break;
                        }
                    case MenuPoint.HireEmployee:
                        {
                            company.HireEmmployee();
                            break;
                        }
                    case MenuPoint.DismissEmployee:
                        {
                            company.DismissEmployee();
                            break;
                        }
                    case MenuPoint.PromoteEmployee:
                        {
                            company.PromoteEmployee();
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unknown command!");
                            Console.ResetColor();
                            break;
                        }
                }

                Console.WriteLine("Input any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }

        static MenuPoint InputMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Command: ");
            int choice = NumbersInput.Integer("Command: ");
            Console.ResetColor();
            return (MenuPoint)choice;
        }

        static void Menu()
        {
            Console.WriteLine("1 - Show employees");
            Console.WriteLine("2 - Show unemployes persons");
            Console.WriteLine("3 - Hire employee");
            Console.WriteLine("4 - Dismiss employee");
            Console.WriteLine("5 - Promote employee");
            Console.WriteLine("6 - Exit");
        }

        enum MenuPoint
        {
            ShowEmployees = 1,
            ShowUnemployedPersons,
            HireEmployee,
            DismissEmployee,
            PromoteEmployee,
            Exit
        }
    }
}
