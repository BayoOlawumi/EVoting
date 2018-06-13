using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    abstract class Employee
    {
        private static int employeeID = 1;
        private string name;
        private double baseSalary;
      

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                baseSalary = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public Employee(string name,double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
            EmployeeID++;
        }
        public double getBaseSalary()
        {
            return BaseSalary;
        }
        public string getName()
        {
            return Name;
        }
        public int getEmployeeID()
        {
            return EmployeeID;
        }
        public string toString()
        {
            return EmployeeID.ToString() + Name;
        }
        public abstract string EmployeeStatus();
      
    }
}
