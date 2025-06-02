using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageSystem
{
    [Serializable]
    public class Employee
    {
        private int basicSalary;
        private string id;
        private string name;

        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Employee(int basicSalary, string id, string name)
        {
            this.BasicSalary = basicSalary;
            this.Id = id;
            this.Name = name;
        }
        public string Display()
        {
            string output = "Name : " + this.Name + "\n" +
                "ID : " + this.Id + "\n" +
                "Basic Salary : " + this.BasicSalary + "\n";
            return output;
        }
    }
}