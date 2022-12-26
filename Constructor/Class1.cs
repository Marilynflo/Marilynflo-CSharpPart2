using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Class1 // adding contructor to initialize the class
    {
        public string Name;
        public int Acctcode;
        public Class1()
        {
        }
        public Class1(string userName)
        {
            this.Name = userName;
        }
        public Class1(string userName, int Acctcode)
            :this(userName)
        {
            this.Acctcode = Acctcode;
        }


    }
}
