using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageSystem
{
    [Serializable]
    public class TemporaryEmployee : Employee
    {
        private DateTime endDate;
        private DateTime startDate;

        public TemporaryEmployee(DateTime endDate, DateTime startDate, int basicSalary, string id, string name):base(basicSalary, id, name)
        {
            this.EndDate = endDate;
            this.StartDate = startDate;
        }

        public DateTime EndDate { get => endDate; set => endDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }

        public double AttedanceBonus()
        {
            double output = 0;
            int numOfAttedance = this.EndDate.Day - this.StartDate.Day;
            output = numOfAttedance * (0.01 * base.BasicSalary);
            return output;
        }
        public double CalculateBonus()
        {
            return (base.BasicSalary * 0.1) + this.AttedanceBonus();
        }

        public string Display()
        {
            string output = "Temporary Employee : " + "\n" + base.Display() +
                "Start Working Date : " + this.StartDate.ToShortDateString() + "\n" +
                "End Working Date : " + this.EndDate.ToShortDateString() + "\n" +
                "Attedance Bonus : " + this.AttedanceBonus() + "\n" +
                "Bonus : " + this.CalculateBonus() + "\n";
            return output;
        }
    }
}