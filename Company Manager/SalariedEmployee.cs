using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    public class SalariedEmployee : Employee
    {
        public int _workload { get; set; }
        public int _unitCharge { get; set; }
        
        public SalariedEmployee() { }

        public SalariedEmployee(string name, int age, string gender, Position role)
           : base(name, age, gender, role)
        {

        }

        public SalariedEmployee(string name, int age, string gender, Position role, int workload, int unitCharge)
           : base(name, age, gender, role)
        {
            _workload = workload;
            _unitCharge = unitCharge;
            SetIncome();
        }

        public override void SetIncome()
        {
            _income = _workload * _unitCharge * 20;
        }

        public void SetIncomeComponents(int workload, int unitCharge)
        {
            _workload = workload;
            _unitCharge = unitCharge;
        }

        public void GetWorkload()
        {
            Console.WriteLine($"{_name} complete {_workload} orders per day");
        }
    }
}
