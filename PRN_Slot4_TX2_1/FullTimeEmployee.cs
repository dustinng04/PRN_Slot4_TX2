using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot4_TX2_1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
        : base(name, paymentPerHour)
        {
        }

        public override int CalculateSalary()
        {
            return 8 * GetPaymentPerHour();
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: {CalculateSalary()}";
        }
    }
}
