using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class BusinessEmployee : Employee
    {
        public double bonusBudet = 1000;

        public BusinessEmployee(String name) : base(name, 50000)
        {

        }

        public override string employeeStatus()
        {
            return toString() + "with a buget of " + this.bonusBudet;
        }
    }
}