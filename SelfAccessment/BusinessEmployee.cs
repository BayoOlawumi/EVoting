using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    class BusinessEmployee:Employee
    {
       
        public double BonusBudget=1000;
        public BusinessEmployee(string name) : base(name, 50000)
        {

        }
        public override string EmployeeStatus()
        {
            return toString()+ "has budget of " + BonusBudget.ToString();
        }
    }
}
