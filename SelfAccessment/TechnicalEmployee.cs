using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    class TechnicalEmployee:Employee
    {
        public int SuccessfulChkIn=4;
        public TechnicalEmployee(string name): base (name, 75000)
        {
       
        }
        public override string EmployeeStatus()
        {
             return EmployeeID.ToString() + Name + "has " + SuccessfulChkIn.ToString()+"  succesful Check in";
        }
    }

}
