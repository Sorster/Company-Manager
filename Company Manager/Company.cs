using System;
using System.Collections.Generic;
using Inputs;

namespace Company_Manager
{
    public class Company 
    {
        List<Employee> Employees = new List<Employee>();
        List<Employee> UnemployedPersons = new List<Employee>();

        //Manual employee adding
        public void AddEmployee(Employee employee, int condition)
        {
            Employees.Add(employee);

            //Searching for the unemployed person and deleting him from the unemployed persons list
            if (condition == 1)
            {
                for (int i = 0; i < UnemployedPersons.Count; i++)
                {
                    if (UnemployedPersons[i] == employee)
                    {
                        UnemployedPersons.RemoveAt(i);
                    }
                }
            }     
        }

        //Manual removing employee
        public void RemoveEmployee(Employee employee, int condition)
        {
            UnemployedPersons.Add(employee);

            //Searching for the employee and deleting him from the employees list
            if (condition == 1)
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    if (Employees[i] == employee)
                    {
                        Employees.RemoveAt(i);
                    }
                }
            }
        }

        public void HireEmmployee()
        {
            if(UnemployedPersons.Count == 0)
            {
                Console.WriteLine("The unemployed persons list is empty!");
            }
            else
            {
                int index = GetIndexOfEmployee(UnemployedPersons);
                Employee employee = UnemployedPersons[index];
                employee = CastToHourlyEmployee(employee);

                if(employee == null)
                {
                    Console.WriteLine("Unknown index!");
                }
                else
                {
                    UnemployedPersons.RemoveAt(index);
                    Employees.Add(employee);
                } 
            } 
        }

        public void DismissEmployee()
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("The unemployed persons list is empty!");
            }
            else
            {
                int index = GetIndexOfUnemploedPerson(Employees);
                Employee employee = Employees[index];


                if (employee != null)
                {
                    Employees.RemoveAt(index);
                    UnemployedPersons.Add(employee);
                }
                else
                {
                    Console.WriteLine("Unknown index!");
                }
            }
        }

        public void PromoteEmployee()
        {
            int index = GetIndexOfEmployee(Employees);
            Employee employee = Employees[index];
            Employees.RemoveAt(index);

            if (employee is Executive)
            {
                Console.WriteLine("Executive is the highest position!");
            }
            else
            {
                if (employee is HourlyEmployee)
                {
                    employee = CastToSalariedEmployee((HourlyEmployee)employee);
                }

                else if (employee is SalariedEmployee)
                {
                    employee = CastToManager((SalariedEmployee)employee);
                }

                else if (employee is Manager)
                {
                    employee = CastToExecutive((Manager)employee);
                }

                Employees.Add(employee);
            }
        }

        static int GetIndexOfEmployee(List<Employee> employees)
        {
            int index;
            do
            {
                Console.WriteLine("Please input index of person");
                index = NumbersInput.Integer("Index: ");
            } while (index > employees.Count || index < 0);

            return index;
        }

        static int GetIndexOfUnemploedPerson(List<Employee> employees)
        {
            int index;
            do
            {
                Console.WriteLine("Please input index of person");
                index = NumbersInput.Integer("Index: ");
            } while (index > employees.Count || index < 0);

            return index;
        }

        public void ShowEmployees()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine($"Employee {i}");
                Employees[i].ShowEmployee();
                Console.WriteLine();
            }
        }

        public void ShowUnemployedPersons()
        {
            for (int i = 0; i < UnemployedPersons.Count; i++)
            {
                Console.WriteLine($"Unemployed person {i}");
                UnemployedPersons[i].ShowUnemployedPeson();
                Console.WriteLine();
            }
        }

        static HourlyEmployee CastToHourlyEmployee(Employee employee)
        {
            HourlyEmployee hourlyEmployee = new HourlyEmployee(employee._name, employee._age, employee._gender, Employee.Position.HourlyEmployee, 8, 5);
            return hourlyEmployee;
        }

        static SalariedEmployee CastToSalariedEmployee(HourlyEmployee hourlyEmployee)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee(hourlyEmployee._name, hourlyEmployee._age, hourlyEmployee._gender, Employee.Position.SalariedEmployee, 5, 15);
            return salariedEmployee;
        }

        static Manager CastToManager(SalariedEmployee salariedEmployee)
        {
            Manager manager = new Manager(salariedEmployee._name, salariedEmployee._age, salariedEmployee._gender, Employee.Position.Manager, 75, 1500);
            return manager;
        }

        static Executive CastToExecutive(Manager manager)
        {
            Executive executive = new Executive(manager._name, manager._age, manager._gender, Employee.Position.SalariedEmployee, 5000);
            return executive;
        }
    }
}
