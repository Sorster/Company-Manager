using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    public class Manager : Employee
    {
        public int _salary { get; set; }
        public int _award { get; set; }
        
        public Manager() { }

        public Manager(string name, int age, string gender, Position role)
           : base(name, age, gender, role)
        {

        }

        public Manager(string name, int age, string gender, Position role, int salary, int award)
           : base(name, age, gender, role)
        {
            _salary = salary;
            _award = award;
            SetIncome();
        }

        public override void SetIncome()
        {
            _income = (_salary * 20) + _award;
        }

        public void SetIncomeComponents(int salary, int award)
        {
            _salary = salary;
            _award = award;
        }

        public void GetAward()
        {
            Console.WriteLine($"{_name} recieve {_award}$ as an award");
        }
    }
}
