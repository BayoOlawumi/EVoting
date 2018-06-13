using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAccessment
{
    abstract class Person:IDisposable
    {
        ~Person()
        {
            Dispose(false);
        }
        private bool idipoe = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool fty)
        {
            if (idipoe)
                return;
            else if (fty)
            {
                //frree other managed objet
            }
            idipoe = true;
        }
        private string name;
        private int age;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
