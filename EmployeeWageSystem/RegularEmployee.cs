using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageSystem
{
    [Serializable]
    public class RegularEmployee : Employee
    {
        private int numOfChildren;

        public int NumOfChildren { get => numOfChildren; set => numOfChildren = value; }

        public RegularEmployee(string name, string id, int basicSalary, int numOfChildren):base(basicSalary,id, name)
        {
            this.NumOfChildren = numOfChildren;
        }
        
        public double ChildrenAllowance()
        {
            double result=0;
            if (this.NumOfChildren <= 3)
            {
                result = this.NumOfChildren * (0.2 * base.BasicSalary);
            }
            return result;
        }

        public double CalculateBonus()
        {
            return base.BasicSalary + this.ChildrenAllowance();
        }

        public string Display()
        {
            string output = "Regular Employee : " + "\n" + base.Display() +
                "Number of Children : " + this.NumOfChildren + "\n" +
                "Children Allowance : " + this.ChildrenAllowance() + "\n" +
                "Bonus : " + this.CalculateBonus() + "\n";

            return output;
        }
    }
}