using System;

namespace Company_Manager
{
    public abstract class Employee
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public string _gender { get; set; }
        public int _income { get; set; }
        public Position _role { get; set; }

        public Employee() { }

        public Employee(string name, int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public Employee(string name, int age, string gender, Position role)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _role = role;
        }

        public void ShowEmployee()
        {
            Console.WriteLine(_name);
            ShowPosition();
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Gender: {_gender}");
            Console.WriteLine($"Total income: {_income}");
        }

        public void ShowUnemployedPeson()
        {
            Console.WriteLine(_name);
            ShowPosition();
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Gender: {_gender}");
        }

        public void SetPosition(int position)
        {
            _role = (Position)position;
        }

        public virtual void SetIncome()
        {
            _income = 0;
        }

        public void ResetEmployee()
        {
            _role = 0;
            _income = 0;
        }

        public void ShowPosition()
        {
            switch(_role)
            {
                case Position.HourlyEmployee:
                    {
                        Console.WriteLine("Hourly Employee");
                        break;
                    }
                case Position.SalariedEmployee:
                    {
                        Console.WriteLine("Salaried Employee");
                        break;
                    }
                case Position.Manager:
                    {
                        Console.WriteLine("Manager");
                        break;
                    }
                case Position.Executive:
                    {
                        Console.WriteLine("Executive");
                        break;
                    }
                case Position.Unemployed:
                    {
                        Console.WriteLine("Unemployed");
                        break;
                    }
            } 
        }

        public enum Position
        {
            HourlyEmployee = 1,
            SalariedEmployee,
            Manager, 
            Executive,
            Unemployed
        }
    }
}
