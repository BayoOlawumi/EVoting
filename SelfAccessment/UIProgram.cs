using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SelfAccessment
{
  
    class UIProgram:IDisposable
    {
        public void Dispose()
        {

        }
        private List<Degree> degs;
        public List<Degree> Degs
        {
            get { return degs; }
            set {   degs = value; }
        }

       
    }
}
