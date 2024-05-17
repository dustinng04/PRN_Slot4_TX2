using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot4_TX2_1
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int CalculateSalary()
        {
            return workingHours * GetPaymentPerHour();
        }
        public override string ToString()
        {
            return base.ToString() + $", Working Hours: {workingHours}, Salary: {CalculateSalary()}";
        }
    }
}
