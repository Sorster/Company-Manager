using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    public class HourlyEmployee : Employee
    {
        public int _workingHours { get; set; }
        public int _paymentPerHour { get; set; }

        public HourlyEmployee() { }

        public HourlyEmployee(string name, int age, string gender)
            :base(name, age, gender)
        {

        }

        public HourlyEmployee(string name, int age, string gender, Position role)
            : base(name, age, gender, role)
        {
            
        }

        public HourlyEmployee(string name, int age, string gender, Position role, int workingHours, int paymentPerHur)
            : base(name, age, gender, role)
        {
            _workingHours = workingHours;
            _paymentPerHour = paymentPerHur;
            SetIncome();
        }

        public override void SetIncome()
        {
            _income = _workingHours * _paymentPerHour * 20;
        }

        public void SetIncomeComponents(int workingHours, int paymentPerHour)
        {
            _workingHours = workingHours;
            _paymentPerHour = paymentPerHour;
        }

        public void GetDailyHours()
        {
            Console.WriteLine($"{_name} works {_workingHours} hours per day");
        }
    }
}