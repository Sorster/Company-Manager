using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    public class Executive : Employee
    {
        public Executive() { }

        public void SetIncome(int income)
        {
            _income = income;
        }

        public Executive(string name, int age, string gender, Position role)
           : base(name, age, gender, role)
        {

        }

        public Executive(string name, int age, string gender, Position role, int salary)
           : base(name, age, gender, role)
        {
            _income = salary * 20;
        }
    }
}
